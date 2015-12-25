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
    public partial class TestDetailForm : Form, FunctionalTypeInterface
    {
        private PresentationModel _presentationModel;
        private ArrayList _arrayList;
        private Test _test;

        public TestDetailForm(PresentationModel presentationModel,Test test)
        {
            InitializeComponent();
            _presentationModel = presentationModel;
            _test = test;
            _arrayList = new ArrayList();
            RefreshTestDetail(test);
        }

        public void RefreshTestDetail(Test test)
        {
            GetTestCaseDetailInformation();
            GetRequirementByTestCaseId();
        }

        public async void GetTestCaseDetailInformation()
        {
            HttpResponseMessage response = await _presentationModel.GetTestCaseDetailInformationByTestCaseId(_test.ID);
            string content = await response.Content.ReadAsStringAsync();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                JObject json = JObject.Parse(content);
                string message = json["result"].ToString();
                JObject jsonObject = JObject.Parse(json["test_case"].ToString());
                if (message == "success")
                {
                    TestName.Text = jsonObject["name"].ToString();
                    idLabel.Text = "ID: "+jsonObject["id"].ToString();
                    JObject temp = JObject.Parse(jsonObject["owner"].ToString());
                    string owner = temp["name"].ToString();
                    ownerLabel.Text = owner;
                    inputDataLabel.Text = jsonObject["input_data"].ToString();
                    expectedResultLabel.Text = jsonObject["expected_result"].ToString();
                    descriptionRichTextBox.Text = jsonObject["description"].ToString();
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

        public async void GetRequirementByTestCaseId()
        {
            HttpResponseMessage response = await _presentationModel.GetRequirementByTestCaseId(_test.ID);
            string content = await response.Content.ReadAsStringAsync();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                JObject json = JObject.Parse(content);
                string message = json["result"].ToString();
                JArray jsonArray = JArray.Parse(json["requirements"].ToString());
                if (message == "success")
                {
                    this._requirementListDataGridView.Rows.Clear();
                    foreach (JObject jObject in jsonArray)
                    {
                        this._requirementListDataGridView.Rows.Add(jObject["name"]);
                        Requirement requirement = new Requirement(int.Parse(jObject["id"].ToString()), int.Parse(jObject["project_id"].ToString()), jObject["name"].ToString(), jObject["description"].ToString(), jObject["version"].ToString(), jObject["description"].ToString());
                        _arrayList.Add(requirement);
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

        public Test Test
        {
            get
            {
                return _test;
            }
        }

        public UserInterfaceForm.FunctionalType GetFunctionalType()
        {
            return UserInterfaceForm.FunctionalType.Edit;
        }
    }
}
