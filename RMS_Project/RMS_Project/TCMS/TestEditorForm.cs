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

        private List<Requirement> _requirementArrayList=new List<Requirement>();
        private List<int> _projectMemberArrayList=new List<int>();
        private int _selectedUserId;
        private List<int> _selectedRequirementId=new List<int>();

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
            GetUserListByProject();
            GetRequirementByProject();
        }

        void confirm_Click(object sender, EventArgs e)
        {
            AddTestToProject();
        }

        async void AddTestToProject()
        {
            JObject jObject = new JObject();
            JArray ridList = new JArray();
            foreach (int rid in _selectedRequirementId)
            {
                JObject ridObject = new JObject();
                ridObject["id"] = rid;
                ridList.Add(ridObject);
            }
            jObject["rid_list"] = ridList;
            jObject["name"] = testNameTextBox.Text;
            jObject["description"] = DescriptionRichTextBox.Text;
            jObject["asigned_as"] = _selectedUserId;
            jObject["input_data"] = AssignmentRichTextBox.Text;
            jObject["expected_result"] = DescriptionRichTextBox.Text;

            //Console.WriteLine(jObject);

            string status = await _presentationModel.AddTestCase(jObject);
            if (status == "success")
            {
                //_presentationModel.AddFormToPanel(new RequirementListForm(_presentationModel, _project));
                MessageBox.Show("測試案例建立成功", "Success", MessageBoxButtons.OK);
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

        public UserInterfaceForm.FunctionalType GetFunctionalType()
        {
            return UserInterfaceForm.FunctionalType.Hide;
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
                    this.checkedListBox.Items.Clear();
                    foreach (JObject jObject in jsonArray)
                    {
                        this.checkedListBox.Items.Add(new Item((int)jObject["id"], jObject["name"].ToString()));

                        Console.WriteLine(jObject["name"]);

                        Requirement requirement = new Requirement((int)jObject["id"], jObject["name"].ToString(), jObject["description"].ToString(), jObject["version"].ToString(), jObject["memo"].ToString());
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
            string content = await response.Content.ReadAsStringAsync();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                JObject json = JObject.Parse(content);
                string message = json["result"].ToString();
                JArray jsonArray = JArray.Parse(json["users"].ToString());
                if (message == "success")
                {
                    for (int i = 0; i < jsonArray.Count; i++)
                    {
                        JObject jObject = jsonArray[i] as JObject;
                        ownerComboBox.Items.Add(new Item(Int32.Parse(jObject["id"].ToString()),jObject["name"].ToString()));
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
            for (int i = 0; i < _projectMemberArrayList.Count; i++)
            {
                if (_projectMemberArrayList.ElementAt(i).CompareTo(ownerComboBox.SelectedValue) == 0)
                {
                    _selectedUserId = _projectMemberArrayList.ElementAt(i);
                    break;
                }
            }
        }

        private void SetSelectedRequirementId()
        {
            for (int i = 0; i < checkedListBox.SelectedIndices.Count; i++)
            {
                _selectedRequirementId.Add(_requirementArrayList[checkedListBox.SelectedIndices[i]].ID);
            }
        }
    }
}
