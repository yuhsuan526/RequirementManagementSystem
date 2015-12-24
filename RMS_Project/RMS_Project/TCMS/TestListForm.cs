using Newtonsoft.Json.Linq;
using System;
using System.Collections;
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
    public partial class TestListForm : Form, FunctionalTypeInterface
    {
        private PresentationModel _presentationModel;
        private Project _project;
        private ArrayList _arrayList;

        public TestListForm(PresentationModel presentationModel, Project project)
        {
            InitializeComponent();
            this._presentationModel = presentationModel;
            this._project = project;
            _arrayList = new ArrayList();
            RefreshTestList();
        }

        public async void RefreshTestList()
        {
            HttpResponseMessage response = await _presentationModel.GetTestCaseListByProjectId(_project.ID);
            string content = await response.Content.ReadAsStringAsync();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                JObject json = JObject.Parse(content);
                string message = json["result"].ToString();
                JArray jsonArray = JArray.Parse(json["test_case_list"].ToString());
                if (message == "success")
                {
                    this.testListDataGridView.Rows.Clear();
                    foreach (JObject jObject in jsonArray)
                    {
                        this.testListDataGridView.Rows.Add(jObject["name"], jObject["id"]);
                        Test project = new Test(int.Parse(jObject["id"].ToString()), _project.ID, jObject["name"].ToString(), jObject["description"].ToString());
                        _arrayList.Add(project);
                    }
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

        void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void testListDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public Project Project
        {
            get
            {
                return _project;
            }
        }

        public UserInterfaceForm.FunctionalType GetFunctionalType()
        {
            return UserInterfaceForm.FunctionalType.New;
        }
    }
}
