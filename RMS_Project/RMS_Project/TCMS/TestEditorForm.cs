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
    public partial class TestEditorForm : Form, FunctionalTypeInterface
    {
        private PresentationModel _presentationModel;
        private Project _project;
        private Test _test;
        private JObject jsonObject;
        private List<Requirement> _requirementArrayList = new List<Requirement>();
        private List<int> _projectMemberArrayList = new List<int>();
        private int _selectedUserId;
        private List<int> _selectedRequirementId = new List<int>();

        public TestEditorForm(PresentationModel presentationModel, Project project)
        {
            InitializeComponent();
            _project = project;
            _presentationModel = presentationModel;

            GetUserListByProject();
            GetRequirementByProject();
        }

        public TestEditorForm(PresentationModel presentationModel, Test test)
        {
            InitializeComponent();
            _test = test;

            _presentationModel = presentationModel;
            GetRequirementByProject();
            GetUserListByTest();
            GetTestCaseDetailInformation();
        }

        void confirm_Click(object sender, EventArgs e)
        {
            SetSelectedRequirementId();
            if (_project != null)
            {
                AddTestToProject();
            }
            else
            {
                EditTestCase();
            }
        }

        async void AddTestToProject()
        {
            JObject jObject = new JObject();
            string temp = "";
            foreach (int rid in _selectedRequirementId)
            {
                temp += rid;
                temp += ",";
            }
            if (temp != "")
                temp = temp.Substring(0, temp.Length - 1);
            jObject["pid"] = _project.ID;
            jObject["rid_list"] = temp;
            jObject["name"] = testNameTextBox.Text;
            jObject["description"] = descriptionRichTextBox.Text;
            jObject["owner"] = _presentationModel.GetUID();
            jObject["asigned_as"] = _selectedUserId;
            jObject["input_data"] = inputDataTextBox.Text;
            jObject["expected_result"] = expectedResultTextBox.Text;

            //Console.WriteLine(jObject);

            string status = await _presentationModel.AddTestCase(jObject);
            if (status == "success")
            {
                MessageBox.Show("測試案例建立成功", "Success", MessageBoxButtons.OK);
                _presentationModel.AddFormToPanel(new TestListForm(_presentationModel, _project));
            }
            else if (status == "測試案例建立失敗")
            {
                MessageBox.Show("測試案例建立失敗", "Error", MessageBoxButtons.OK);
            }
            else if (status == "伺服器無回應")
            {
                MessageBox.Show("測試案例器無回應", "Error", MessageBoxButtons.OK);
            }
        }

        async void EditTestCase()
        {
            JObject jObject = new JObject();
            jObject["id"] = _test.ID.ToString();
            jObject["pid"] = _test.ProjectID;
            jObject["name"] = testNameTextBox.Text;
            jObject["description"] = descriptionRichTextBox.Text;
            jObject["owner"] = _presentationModel.GetUID();
            jObject["asigned_as"] = _selectedUserId;
            jObject["input_data"] = inputDataTextBox.Text;
            jObject["expected_result"] = expectedResultTextBox.Text;
            string temp = "";
            foreach (int rid in _selectedRequirementId)
            {
                temp += rid;
                temp += ",";
            }
            if (temp != "")
                temp = temp.Substring(0, temp.Length - 1);
            jObject["rid_list"] = temp;
            jObject["finished"] = 0;

            string status = await _presentationModel.EditTestCase(jObject);
            if (status == "success")
            {
                MessageBox.Show("測試案例修改成功", "Success", MessageBoxButtons.OK);
                TestDetailForm form = _presentationModel.GetFormByType(typeof(TestDetailForm)) as TestDetailForm;
                form.RefreshTestDetail(_test);
                _presentationModel.PopFormFromPanel();
            }
            else if (status == "測試案例修改失敗")
            {
                MessageBox.Show("測試案例修改失敗", "Error", MessageBoxButtons.OK);
            }
            else if (status == "伺服器無回應")
            {
                MessageBox.Show("測試案例伺服器無回應", "Error", MessageBoxButtons.OK);
            }
        }

        public UserInterfaceForm.FunctionalType GetFunctionalType()
        {
            return UserInterfaceForm.FunctionalType.Hide;
        }

        private async void GetRequirementByProject()
        {
            HttpResponseMessage response;
            if (_project != null)
            {
                response = await _presentationModel.GetRequirementByProject(_project.ID.ToString());
                GetRequirementByResponse(response);
            }
            else
            {
                response = await _presentationModel.GetRequirementByProject(_test.ProjectID.ToString());
                GetRequirementByResponse(response);
                GetRequirementByTest();
            }
        }

        private async void GetRequirementByTest()
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
                    foreach (JObject jObject in jsonArray)
                    {
                        string name = jObject["name"].ToString();
                        for (int i = 0; i < checkedListBox.Items.Count; i++)
                        {
                            if (name.Equals(checkedListBox.Items[i].ToString()))
                            {
                                checkedListBox.SetItemChecked(i, true);
                            }
                        }
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

        private async void GetRequirementByResponse(HttpResponseMessage response)
        {
            string content = await response.Content.ReadAsStringAsync();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                JObject json = JObject.Parse(content);
                string message = json["result"].ToString();
                JArray jsonArray = JArray.Parse(json["requirements"].ToString());
                if (message == "success")
                {
                    this.checkedListBox.Items.Clear();
                    _requirementArrayList.Clear();
                    foreach (JObject jObject in jsonArray)
                    {
                        this.checkedListBox.Items.Add(new Item((int)jObject["id"], jObject["name"].ToString()));
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
                        Requirement requirement = new Requirement((int)jObject["id"], (int)jObject["project_id"], jObject["name"].ToString(), owner, handler,
                            jObject["description"].ToString(), jObject["version"].ToString(), jObject["memo"].ToString(),
                            type, priority, status);
                        _requirementArrayList.Add(requirement);
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

        private async void GetUserListByProject()
        {
            HttpResponseMessage response = await _presentationModel.GetUserListByProject(_project.ID.ToString());
            GetUserListByResponse(response);
        }

        private async void GetUserListByTest()
        {
            HttpResponseMessage response = await _presentationModel.GetUserListByProject(_test.ProjectID.ToString());
            GetUserListByResponse(response);
        }

        private async void GetUserListByResponse(HttpResponseMessage response)
        {
            string content = await response.Content.ReadAsStringAsync();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                JObject json = JObject.Parse(content);
                string message = json["result"].ToString();
                JArray jsonArray = JArray.Parse(json["users"].ToString());
                if (message == "success")
                {
                    ownerComboBox.Items.Clear();
                    _projectMemberArrayList.Clear();
                    for (int i = 0; i < jsonArray.Count; i++)
                    {
                        JObject jObject = jsonArray[i] as JObject;
                        if (!jObject["priority_type_name"].ToString().Equals("Customer"))
                        {
                            ownerComboBox.Items.Add(new Item(Int32.Parse(jObject["id"].ToString()), jObject["name"].ToString()));
                            _projectMemberArrayList.Add(Int32.Parse(jObject["id"].ToString()));
                            if (jsonObject != null)
                            {
                                JObject temp = JObject.Parse(jsonObject["owner"].ToString());
                                string owner = temp["name"].ToString();
                                if (owner == jObject["name"].ToString())
                                    ownerComboBox.SelectedItem = ownerComboBox.Items[i];
                            }
                        }
                    }
                    if (_test == null)
                    {
                        if (jsonArray.Count > 0)
                            ownerComboBox.SelectedItem = ownerComboBox.Items[0];
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

        public async void GetTestCaseDetailInformation()
        {
            HttpResponseMessage response = await _presentationModel.GetTestCaseDetailInformationByTestCaseId(_test.ID);
            string content = await response.Content.ReadAsStringAsync();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                JObject json = JObject.Parse(content);

                string message = json["result"].ToString();
                jsonObject = JObject.Parse(json["test_case"].ToString());
                if (message == "success")
                {
                    testNameTextBox.Text = jsonObject["name"].ToString();
                    inputDataTextBox.Text = jsonObject["input_data"].ToString();
                    expectedResultTextBox.Text = jsonObject["expected_result"].ToString();
                    descriptionRichTextBox.Text = jsonObject["description"].ToString();
                    if (ownerComboBox.Items != null)
                    {
                        for (int i = 0; i < ownerComboBox.Items.Count; i++)
                        {
                            if (_test == null)
                            {
                                ownerComboBox.SelectedItem = ownerComboBox.Items[0];
                                break;
                            }
                            if (jsonObject != null)
                            {
                                JObject temp = JObject.Parse(jsonObject["owner"].ToString());
                                string owner = temp["name"].ToString();
                                if (owner.Equals(ownerComboBox.Items[i].ToString()))
                                    ownerComboBox.SelectedItem = ownerComboBox.Items[i];
                            }
                        }
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

        private void ownerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedUserId = _projectMemberArrayList[ownerComboBox.SelectedIndex];
        }

        private void SetSelectedRequirementId()
        {
            _selectedRequirementId.Clear();
            for (int i = 0; i < checkedListBox.CheckedItems.Count; i++)
            {
                _selectedRequirementId.Add(_requirementArrayList[checkedListBox.CheckedIndices[i]].ID);
            }
        }
    }
}
