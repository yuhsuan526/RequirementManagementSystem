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
        private ArrayList _requirementArrayList;
        private ArrayList _projectMemberArrayList;

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
        }

        void confirm_Click(object sender, EventArgs e)
        {
            AddTestToProject();
        }

        async void AddTestToProject()
        {
            JObject jObject = new JObject();
            //jObject["rid_list"] = ;
            jObject["name"] = testNameTextBox.Text;
            jObject["description"] = DescriptionRichTextBox.Text;
            //jObject["asigned_as"] = ownerComboBox.SelectedItem.;
            jObject["input_data"] = AssignmentRichTextBox.Text;
            jObject["expected_result"] = DescriptionRichTextBox.Text;

            string status = await _presentationModel.AddTestCase(jObject);
            if (status == "success")
            {
                //_presentationModel.AddFormToPanel(new RequirementListForm(_presentationModel, _project));
                MessageBox.Show("需求建立成功", "Success", MessageBoxButtons.OK);
            }
            else if (status == "需求建立失敗")
            {
                MessageBox.Show("需求建立失敗", "Error", MessageBoxButtons.OK);
            }
            else if (status == "伺服器無回應")
            {
                MessageBox.Show("伺服器無回應", "Error", MessageBoxButtons.OK);
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
                    this.ownerComboBox.Items.Clear();
                    foreach (JObject jObject in jsonArray)
                    {
                        this.checkedListBox.Items.Add(jObject["name"]);
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
                    ListViewItem[] items = new ListViewItem[jsonArray.Count];
                    for (int i = 0; i < jsonArray.Count; i++)
                    {
                        JObject jObject = jsonArray[i] as JObject;
                        ListViewItem item = new ListViewItem(new string[] { jObject["name"].ToString(), jObject["email"].ToString() }, 0);
                        items[i] = item;
                    }
                    ownerComboBox.Items.Clear();
                    ownerComboBox.Items.AddRange(items);
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
    }
}
