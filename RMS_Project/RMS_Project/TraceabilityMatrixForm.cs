using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS_Project
{
    public partial class TraceabilityMatrixForm : Form, FunctionalTypeInterface
    {
        private Project _project;
        private PresentationModel _presentationModel;
        private Requirement[] requirementList;
        private Test[] testList;
        private int _counter;
        private int _maxCount;

        public TraceabilityMatrixForm(PresentationModel presentationModel, Project project)
        {
            InitializeComponent();
            _project = project;
            _presentationModel = presentationModel;
            GetRequirementByProject();
        }

        private void CreateCell(string[] rows, string[] columns)
        {
            matrixDataGridView.Columns.Clear();
            matrixDataGridView.Rows.Clear();
            DataGridViewColumnCollection matrixColumns = matrixDataGridView.Columns;
            matrixColumns.Add("nullColumn", "Traceability Matrix");
            for (int j = 0; j < columns.Length; j++)
            {
                DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
                checkColumn.Name = "testColumn";
                checkColumn.HeaderText = columns[j];
                checkColumn.TrueValue = true;
                checkColumn.FalseValue = false;
                checkColumn.FillWeight = 10;
                matrixColumns.Add(checkColumn);
            }
            DataGridViewRowCollection matrixRows = matrixDataGridView.Rows;
            for (int i = 0; i < rows.Length; i++)
            {
                matrixRows.Add(rows[i]);
            }
            matrixDataGridView.Columns[0].Frozen = true;
            matrixDataGridView.Columns[0].ReadOnly = true;
            GetRequirementToRequirementRelationByProjectId();
        }

        private void SetCellValue(string rowID, string columnID)
        {
            int rowIndex = -1;
            int columnIndex = -1;
            for (int i = 0; i < requirementList.Length; i++)
            {
                if (requirementList[i].ID.ToString().Equals(rowID))
                {
                    rowIndex = i;
                    if (columnIndex >= 0)
                        break;
                }
                if (requirementList[i].ID.ToString().Equals(columnID))
                {
                    columnIndex = i;
                    if (rowIndex >= 0)
                        break;
                }
            }
            DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)matrixDataGridView.Rows[rowIndex].Cells[1 + columnIndex];
            chk.Value = chk.TrueValue;

        }

        public async void AddRelation()
        {
            try
            {
                string msg = await _presentationModel.DeleteRequirementToRequirementRelationByProject(_project.ID);
                _maxCount = 0;
                _counter = 0;
                for (int i = 0; i < matrixDataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < matrixDataGridView.Columns.Count - 1; j++)
                    {
                        DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)matrixDataGridView.Rows[i].Cells[1 + j];
                        if (chk.Value == chk.TrueValue)
                        {
                            _maxCount++;
                            JObject jObject = new JObject();
                            jObject["r1id"] = requirementList[i].ID;
                            jObject["r2id"] = requirementList[j].ID;
                            jObject["pid"] = _project.ID;
                            CreateRequirementToRequirementRelation(jObject);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK);
            }
        }

        public async void CreateRequirementToRequirementRelation(JObject jObject)
        {
            string msg = await _presentationModel.CreateRequirementToRequirementRelation(jObject);
            _counter++;
            if (_maxCount <= _counter)
            {
                MessageBox.Show("修改成功", "Success", MessageBoxButtons.OK);
            }
        }

        private async void GetRequirementToRequirementRelationByProjectId()
        {
            try
            {
                JArray jsonArray = await _presentationModel.GetRequirementToRequirementRelationByProjectId(_project.ID);
                for (int i = 0; i < jsonArray.Count; i++)
                {
                    JObject jObject = (JObject)jsonArray[i];
                    SetCellValue(jObject["requirement1_id"].ToString(), jObject["requirement2_id"].ToString());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private async void GetRequirementByProject()
        {
            HttpResponseMessage response = await _presentationModel.GetRequirementByProject(_project.ID.ToString());
            string content = await response.Content.ReadAsStringAsync();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                JObject json = JObject.Parse(content);
                string message = json["result"].ToString();
                JArray jsonArray = JArray.Parse(json["requirements"].ToString());
                if (message == "success")
                {
                    requirementList = new Requirement[jsonArray.Count];
                    for (int i = 0; i < jsonArray.Count; i++ )
                    {
                        JObject jObject = (JObject)jsonArray[i];
                        requirementList[i] = 
                            new Requirement(
                            int.Parse(jObject["id"].ToString()), 
                            _project.ID, 
                            jObject["name"].ToString(),
                            jObject["description"].ToString(), 
                            jObject["version"].ToString(), 
                            jObject["memo"].ToString(),
                            int.Parse(jObject["requirement_type_id"].ToString()), 
                            int.Parse(jObject["priority_type_id"].ToString()), 
                            int.Parse(jObject["status_type_id"].ToString()));
                    }
                    string[] rList = new string[requirementList.Length];
                    for (int i = 0; i < requirementList.Length; i++)
                    {
                        rList[i] = requirementList[i].Name;
                    }
                    CreateCell(rList, rList);
                    //RefreshTestList();
                }
            }
            else if (response.StatusCode == HttpStatusCode.RequestTimeout)
            {
                MessageBox.Show("伺服器無回應", "Error", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("伺服器錯誤", "Error", MessageBoxButtons.OK);
            }
        }

        public async void RefreshTestList()
        {
            HttpResponseMessage response = await _presentationModel.GetTestCaseListByRequirementId(_project.ID);
            string content = await response.Content.ReadAsStringAsync();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                JObject json = JObject.Parse(content);
                string message = json["result"].ToString();
                JArray jsonArray = JArray.Parse(json["test_case_list"].ToString());
                if (message == "success")
                {
                    testList = new Test[jsonArray.Count];
                    for (int i = 0; i < jsonArray.Count; i++)
                    {
                        JObject jObject = (JObject)jsonArray[i];
                        testList[i] = new Test(int.Parse(jObject["id"].ToString()), _project.ID, 
                            jObject["name"].ToString(), jObject["description"].ToString());
                    }
                    string[] rList = new string[requirementList.Length];
                    for (int i = 0; i < requirementList.Length; i++)
                    {
                        rList[i] = requirementList[i].Name;
                    }
                    string[] tList = new string[testList.Length];
                    for (int i = 0; i < testList.Length; i++)
                    {
                        tList[i] = testList[i].NAME;
                    }
                    CreateCell(rList, rList);
                }
            }
            else if (response.StatusCode == HttpStatusCode.RequestTimeout)
            {
                MessageBox.Show("伺服器無回應", "Error", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("伺服器錯誤", "Error", MessageBoxButtons.OK);
            }
        }

        public UserInterfaceForm.FunctionalType GetFunctionalType()
        {
            return UserInterfaceForm.FunctionalType.New;
        }
    }
}
