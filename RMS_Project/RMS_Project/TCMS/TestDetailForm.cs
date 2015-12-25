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
        private UserInterfaceForm.FunctionalType type;

        public TestDetailForm(PresentationModel presentationModel,Test test)
        {
            InitializeComponent();
            _presentationModel = presentationModel;
            _test = test;
            _arrayList = new ArrayList();
            type = UserInterfaceForm.FunctionalType.Hide;
            RefreshTestDetail(test);
            CheckPriority();
        }

        public void RefreshTestDetail(Test test)
        {
            
            _test = test;
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

                //Console.WriteLine(json.ToString());

                string message = json["result"].ToString();
                JObject jsonObject = JObject.Parse(json["test_case"].ToString());
                if (message == "success")
                {
                    testName.Text = jsonObject["name"].ToString();
                    idLabel.Text = jsonObject["id"].ToString();
                    JObject temp = JObject.Parse(jsonObject["owner"].ToString());
                    string owner = temp["name"].ToString();
                    ownerLabel.Text = owner;
                    JObject jHandler = JObject.Parse(jsonObject["asigned_as"].ToString());
                    string handler = jHandler["name"].ToString();
                    handlerLabel.Text = handler;
                    inputDataLabel.Text = jsonObject["input_data"].ToString();
                    expectedResultLabel.Text = jsonObject["expected_result"].ToString();
                    descriptionTextBox.Text = jsonObject["description"].ToString();
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
                        JObject jOwner = jObject["owner"] as JObject;
                        JObject jHandler = jObject["handler"] as JObject;
                        JObject jType = jObject["requirement_type"] as JObject;
                        JObject jPriority = jObject["priority_type"] as JObject;
                        JObject jStatus = jObject["status_type"] as JObject;
                        User owner = _presentationModel.getUser((int)jOwner["id"], jOwner["name"].ToString());
                        User handler = _presentationModel.getUser((int)jHandler["id"], jHandler["name"].ToString());
                        NormalAttribute type = _presentationModel.getRequirementAttribute((int)jType["id"], jType["name"].ToString());
                        NormalAttribute priority = _presentationModel.getRequirementAttribute((int)jPriority["id"], jPriority["name"].ToString());
                        NormalAttribute status = _presentationModel.getRequirementAttribute((int)jStatus["id"], jStatus["name"].ToString());
                        Requirement requirement = new Requirement((int)jObject["id"], int.Parse(jObject["project_id"].ToString()), jObject["name"].ToString(), owner, handler,
                            jObject["description"].ToString(), jObject["version"].ToString(), jObject["memo"].ToString(),
                            type, priority, status);
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
            return type;
        }

        private async void CheckPriority()
        {
            JObject jObject = await _presentationModel.GetPriority(_test.ProjectID);
            if (jObject["priority_type_name"].ToString().Equals("Owner") ||
                jObject["priority_type_name"].ToString().Equals("Manager"))
            {
                type = UserInterfaceForm.FunctionalType.Edit;
                _presentationModel.SetFunctionalButton(type);
            }
        }
    }
}
