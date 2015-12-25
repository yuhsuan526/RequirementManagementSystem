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
        Requirement[] requirementList;
        Test[] testList;


        public TraceabilityMatrixForm(PresentationModel presentationModel, Project project)
        {
            InitializeComponent();
            _project = project;
            _presentationModel = presentationModel;
            /*
            DataGridViewColumnCollection columns = matrixDataGridView.Columns;
            columns.Add("nullColumn", "Traceability Matrix");
            columns.Add("testColumn1", "Test 1");
            columns.Add("testColumn2", "Test 2");
            columns.Add("testColumn3", "Test 3");
            columns.Add("testColumn4", "Test 4");
            columns.Add("testColumn5", "Test 5");
            columns.Add("testColumn6", "Test 6");
            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.Name = "testColumn7";
            checkColumn.HeaderText = "Test 7";
            checkColumn.TrueValue = true;
            checkColumn.FalseValue = false;
            checkColumn.FillWeight = 10; //if the datagridview is resized (on form resize) the checkbox won't take up too much; value is relative to the other columns' fill values
            matrixDataGridView.Columns.Add(checkColumn);

            columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);

            DataGridViewRowCollection rows = matrixDataGridView.Rows;
            rows.Add("Requirement 1");
            rows.Add("Requirement 2");
            rows.Add("Requirement 3");
            rows.Add("Requirement 4");
            rows.Add("Requirement 5");
            rows.Add("Requirement 6");
            rows.Add("Requirement 7");
            rows.Add("Requirement 8");
            rows.Add("Requirement 9");
            rows.Add("Requirement 10");
            rows.Add("Requirement 11");
            rows.Add("Requirement 12");
            matrixDataGridView.Columns[0].Frozen = true;
            bool flag = false;
            foreach (DataGridViewRow row in matrixDataGridView.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[7];
                chk.Selected = flag;
                flag = !flag;
            }*/

            //CreateCell(new string[]{"1", "2"}, new string[]{"1", "2"});
            GetRequirementByProject();
        }

        private void CreateCell(string[] rows, string[] columns)
        {
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
            bool flag = false;
            
            for (int i = 0; i < rows.Length; i++)
            {
                for (int j = 0; j < columns.Length; j++)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)matrixDataGridView.Rows[i].Cells[1 + j];
                    chk.Selected = flag;
                    flag = !flag;
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
                    requirementList = new Requirement[jsonArray.Count];
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
                        Requirement requirement = new Requirement((int)jObject["id"], _project.ID, jObject["name"].ToString(), owner, handler,
                            jObject["description"].ToString(), jObject["version"].ToString(), jObject["memo"].ToString(),
                            (int)jObject["requirement_type_id"], (int)jObject["priority_type_id"], (int)jObject["status_type_id"]);
                    }
                    RefreshTestList();
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
            return UserInterfaceForm.FunctionalType.Hide;
        }
    }
}
