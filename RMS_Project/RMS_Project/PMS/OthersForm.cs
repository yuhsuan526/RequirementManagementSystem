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
    public partial class OthersForm : Form, FunctionalTypeInterface
    {
        private Project _project;
        private PresentationModel _presentationModel;
        private Requirement[] _requirements;
        private Test[] _tests;
        private int _counter;
        private int _maxCount;
        private UserInterfaceForm.FunctionalType _functionalType;

        public OthersForm(PresentationModel presentationModel, Project project)
        {
            InitializeComponent();
            _project = project;
            _presentationModel = presentationModel;
            _functionalType = UserInterfaceForm.FunctionalType.Hide;
            GetRequirementByProject();
        }

        private void CreateDataGridViewCell(DataGridView dataGridView, string[] rows, string[] columns)
        {
            dataGridView.Columns.Clear();
            dataGridView.Rows.Clear();
            DataGridViewColumnCollection matrixColumns = dataGridView.Columns;
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
            DataGridViewRowCollection matrixRows = dataGridView.Rows;
            for (int i = 0; i < rows.Length; i++)
            {
                matrixRows.Add(rows[i]);
            }
            dataGridView.Columns[0].Frozen = true;
            dataGridView.Columns[0].ReadOnly = true;
        }

        private void SetDataGridViewCheckBoxCellValue(string rowID, string columnID)
        {
            int rowIndex = -1;
            int columnIndex = -1;
            for (int i = 0; i < _requirements.Length; i++)
            {
                if (_requirements[i].ID.ToString().Equals(rowID))
                {
                    rowIndex = i;
                    if (columnIndex >= 0)
                        break;
                }
                if (_requirements[i].ID.ToString().Equals(columnID))
                {
                    columnIndex = i;
                    if (rowIndex >= 0)
                        break;
                }
            }
            DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)_RtoRDataGridView.Rows[rowIndex].Cells[1 + columnIndex];
            chk.Value = chk.TrueValue;

        }

        public void ClickFunctionalButton()
        {
            if (_othersTabControl.SelectedTab == tabPage3)
            {

            }
            else if (_othersTabControl.SelectedTab == tabPage4)
            {

            }
        }

        public async void AddRtoRRelation()
        {
            try
            {
                string msg = await _presentationModel.DeleteRequirementToRequirementRelationByProject(_project.ID);
                _maxCount = 0;
                _counter = 0;
                for (int i = 0; i < _RtoRDataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < _RtoRDataGridView.Columns.Count - 1; j++)
                    {
                        DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)_RtoRDataGridView.Rows[i].Cells[1 + j];
                        if (chk.Value == chk.TrueValue)
                        {
                            _maxCount++;
                            JObject jObject = new JObject();
                            jObject["r1id"] = _requirements[i].ID;
                            jObject["r2id"] = _requirements[j].ID;
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

        public async void AddRtoTRelation()
        {
            try
            {
                string msg = await _presentationModel.DeleteRequirementToTestRelationByProject(_project.ID);
                _maxCount = 0;
                _counter = 0;
                for (int i = 0; i < _RtoTDataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < _RtoTDataGridView.Columns.Count - 1; j++)
                    {
                        DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)_RtoTDataGridView.Rows[i].Cells[1 + j];
                        if (chk.Value == chk.TrueValue)
                        {
                            _maxCount++;
                            JObject jObject = new JObject();
                            jObject["rid"] = _requirements[i].ID;
                            jObject["tid"] = _tests[j].ID;
                            jObject["pid"] = _project.ID;
                            CreateRequirementToTestRelation(jObject);
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

        public async void CreateRequirementToTestRelation(JObject jObject)
        {
            string msg = await _presentationModel.CreateRequirementToTestRelation(jObject);
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
                    SetDataGridViewCheckBoxCellValue(jObject["requirement1_id"].ToString(), jObject["requirement2_id"].ToString());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private async void GetRequirementToTestRelationByProjectId()
        {
            try
            {
                JArray jsonArray = await _presentationModel.GetRequirementToTestRelationByProjectId(_project.ID);
                for (int i = 0; i < jsonArray.Count; i++)
                {
                    JObject jObject = (JObject)jsonArray[i];
                    SetDataGridViewCheckBoxCellValue(jObject["requirement1_id"].ToString(), jObject["requirement2_id"].ToString());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void CreateAllDataGridView()
        {
            foreach(Requirement requirement in _requirements)
            {
                Console.WriteLine(requirement.Status.ToString());
                if (requirement.Status.ID == 3)
                {
                    _approvedRequirementDataGridView.Rows.Add(requirement.Name);
                }
                else if (requirement.Status.ID == 4)
                {
                    _notApprovedRequirementDataGridView.Rows.Add(requirement.Name);
                }
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
                    _requirements = new Requirement[jsonArray.Count];
                    for (int i = 0; i < jsonArray.Count; i++ )
                    {
                        JObject jObject = (JObject)jsonArray[i];
                        User owner = new User();
                        User handler = new User();
                        JObject jOwner = jObject["owner"] as JObject;
                        owner.ID = (int)jOwner["id"];
                        owner.Name = jOwner["name"].ToString();
                        JObject jHandler = jObject["handler"] as JObject;
                        handler.ID = (int)jHandler["id"];
                        handler.Name = jHandler["name"].ToString();
                        _requirements[i] = 
                            new Requirement(
                            int.Parse(jObject["id"].ToString()), 
                            _project.ID,
                            jObject["name"].ToString(), owner, handler,
                            jObject["description"].ToString(), 
                            jObject["version"].ToString(), 
                            jObject["memo"].ToString(),
                            null, 
                            null, 
                            null);
                    }
                    string[] rList = new string[_requirements.Length];
                    for (int i = 0; i < _requirements.Length; i++)
                    {
                        rList[i] = _requirements[i].Name;
                    }
                    CreateAllDataGridView();
                    CreateDataGridViewCell(_RtoRDataGridView, rList, rList);
                    GetRequirementToRequirementRelationByProjectId();
                    GetTestListByProject();
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

        public async void GetTestListByProject()
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
                    _tests = new Test[jsonArray.Count];
                    for (int i = 0; i < jsonArray.Count; i++)
                    {
                        JObject jObject = (JObject)jsonArray[i];
                        _tests[i] = new Test(int.Parse(jObject["id"].ToString()), _project.ID, 
                            jObject["name"].ToString(), jObject["description"].ToString());
                    }
                    string[] rList = new string[_requirements.Length];
                    for (int i = 0; i < _requirements.Length; i++)
                    {
                        rList[i] = _requirements[i].Name;
                    }
                    string[] tList = new string[_tests.Length];
                    for (int i = 0; i < _tests.Length; i++)
                    {
                        tList[i] = _tests[i].NAME;
                    }
                    CreateDataGridViewCell(_RtoTDataGridView, rList, tList);
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
            return _functionalType;
        }

        private void _othersTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_othersTabControl.SelectedTab == tabPage3)
            {
                _functionalType = UserInterfaceForm.FunctionalType.Edit;
            }
            else if (_othersTabControl.SelectedTab == tabPage4)
            {
                _functionalType = UserInterfaceForm.FunctionalType.Edit;
            }
            else
            {
                _functionalType = UserInterfaceForm.FunctionalType.Hide;
            }
            _presentationModel.SetFunctionalButton(this.GetFunctionalType());
        }
    }
}
