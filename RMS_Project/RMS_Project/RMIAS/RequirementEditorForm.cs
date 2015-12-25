using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Net.Http;

namespace RMS_Project
{
    public partial class RequirementEditorForm : Form, FunctionalTypeInterface
    {
        private const string PRIORITY = "getPriorityType";
        private const string REQUIREMENT = "getRequirementType";
        private const string STATUS = "getStatusType";

        private PresentationModel _presentationModel;
        private Project _project;
        private Requirement _requirement;
        private List<int> _projectMemberArrayList;
        private int _selectedType;
        private int _selectedStatus;
        private int _selectedPriority;
        private int _selectedHandler;

        private List<int> _projectIds;
        private List<string> _projectNames;
        private List<int> _requireIds;
        private List<string> _requireNames;
        private List<int> _statusIds;
        private List<string> _statusNames;

        public RequirementEditorForm(PresentationModel presentationModel, Project project)
        {
            InitializeComponent();
            this._presentationModel = presentationModel;
            this._project = project;
            versionLabel.Text = "1";
            GetUserListByProject();

            _projectIds = new List<int>();
            _projectNames = new List<string>();
            _requireIds = new List<int>();
            _requireNames = new List<string>();
            _statusIds = new List<int>();
            _statusNames = new List<string>();
            _projectMemberArrayList = new List<int>();

            GetRequirementMethod(PRIORITY);
            GetRequirementMethod(REQUIREMENT);
            GetRequirementMethod(STATUS);
        }

        public RequirementEditorForm(PresentationModel presentationModel, Requirement requirement)
        {
            InitializeComponent();
            this._presentationModel = presentationModel;
            this._requirement = requirement;
            GetUserListByProject();

            _projectIds = new List<int>();
            _projectNames = new List<string>();
            _requireIds = new List<int>();
            _requireNames = new List<string>();
            _statusIds = new List<int>();
            _statusNames = new List<string>();
            _projectMemberArrayList = new List<int>();

            GetRequirementMethod(PRIORITY);
            GetRequirementMethod(REQUIREMENT);
            GetRequirementMethod(STATUS);

            nameTextBox.Text = _requirement.Name;
            //typeComboBox.Text = _requireNames.ElementAt(_requirement.Type - 1);
            versionLabel.Text = (Int32.Parse(_requirement.Version) + 1).ToString();
            //priorityComboBox.Text = _projectNames.ElementAt(_requirement.Priority - 1);
            //statusComboBox.Text = _statusNames.ElementAt(_requirement.Status - 1);
            DescriptionRichTextBox.Text = _requirement.Description;
            MemoRichTextBox.Text = _requirement.Memo;
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            if (_requirement == null)
                AddRequirementToProject();
            else {
                _requirement.Name = nameTextBox.Text;
                _requirement.Type = _selectedType;
                _requirement.Version = (Int32.Parse(versionLabel.Text)).ToString();
                _requirement.Priority = _selectedPriority;
                _requirement.Status = _selectedStatus;
                _requirement.Description = DescriptionRichTextBox.Text;
                _requirement.Memo = MemoRichTextBox.Text;
                EditRequirement();
            }
        }

        private async void AddRequirementToProject()
        {
            JObject jObject = new JObject();
            jObject["name"] = nameTextBox.Text;
            jObject["description"] = DescriptionRichTextBox.Text;
            jObject["version"] = 1;
            jObject["memo"] = MemoRichTextBox.Text;
            jObject["handler"] = _selectedHandler;
            jObject["uid"] = _presentationModel.GetUID();
            jObject["pid"] = _project.ID;
            jObject["requirement_type_id"] = _selectedType;
            jObject["priority_type_id"] = _selectedPriority;
            jObject["status_type_id"] = _selectedStatus;

            string status = await _presentationModel.AddRequirement(jObject);
            if (status == "success")
            {
                RequirementListForm form = _presentationModel.GetFormByType(typeof(RequirementListForm)) as RequirementListForm;
                form.RefreshRequirementList();
                _presentationModel.PopFormFromPanel();
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

        private async void EditRequirement() {
            string message = await _presentationModel.EditRequirement(_requirement);
            try
            {
                RequirementDetailForm form = _presentationModel.GetFormByType(typeof(RequirementDetailForm)) as RequirementDetailForm;
                form.RefreshRequirementDetail(_requirement);
                _presentationModel.PopFormFromPanel();
                MessageBox.Show(message, "Success", MessageBoxButtons.OK);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private async void GetRequirementMethod(String method)
        {
            HttpResponseMessage response = await _presentationModel.GetRequirementMethod(method);

            string content = await response.Content.ReadAsStringAsync();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                JObject json = JObject.Parse(content);
                string message = json["result"].ToString();
                JArray jsonArray = null;
                switch (method)
                {
                    case PRIORITY:
                        jsonArray = JArray.Parse(json["priority"].ToString());
                        if (message == "success" && jsonArray != null)
                        {
                            foreach (JObject jObject in jsonArray)
                            {
                                int id = (int)jObject["id"];
                                string name = jObject["name"].ToString();
                                this._projectIds.Add(id);
                                this._projectNames.Add(name);
                            }
                        }
                        for (int i = 0; i < _projectIds.Count; i++)
                            priorityComboBox.Items.Add(new Item(_projectIds.ElementAt(i), _projectNames.ElementAt(i)));
                        break;
                    case REQUIREMENT:
                        jsonArray = JArray.Parse(json["type"].ToString());
                        if (message == "success" && jsonArray != null)
                        {
                            foreach (JObject jObject in jsonArray)
                            {
                                int id = (int)jObject["id"];
                                string name = jObject["name"].ToString();
                                this._requireIds.Add(id);
                                this._requireNames.Add(name);
                            }
                        }
                        for (int i = 0; i < _requireIds.Count; i++)
                            typeComboBox.Items.Add(new Item(_requireIds.ElementAt(i), _requireNames.ElementAt(i)));
                        break;
                    case STATUS:
                        jsonArray = JArray.Parse(json["statuses"].ToString());
                        if (message == "success" && jsonArray != null)
                        {
                            foreach (JObject jObject in jsonArray)
                            {
                                int id = (int)jObject["id"];
                                string name = jObject["name"].ToString();
                                this._statusIds.Add(id);
                                this._statusNames.Add(name);
                            }
                        }
                        for (int i = 0; i < _statusIds.Count; i++)
                            statusComboBox.Items.Add(new Item(_statusIds.ElementAt(i), _statusNames.ElementAt(i)));
                        break;
                    default:
                        break;
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

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //for (int i = 0; i < _requireNames.Count; i++)
            //{
            //    if (_requireNames.ElementAt(i).CompareTo(typeComboBox.SelectedValue) == 0)
            //    {
            //        _selectedType = _requireIds.ElementAt(i);
            //        break;
            //    }
            //}
            _selectedType = typeComboBox.SelectedIndex + 1;
        }

        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //for (int i = 0; i < _statusNames.Count; i++)
            //{
            //    if (_statusNames.ElementAt(i).CompareTo(statusComboBox.SelectedValue) == 0)
            //    {
            //        _selectedStatus = _statusIds.ElementAt(i);
            //        break;
            //    }
            //}
            _selectedStatus = statusComboBox.SelectedIndex + 1;
        }

        private void priorityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //for (int i = 0; i < _projectNames.Count; i++)
            //{
            //    if (_projectNames.ElementAt(i).CompareTo(priorityComboBox.SelectedValue) == 0)
            //    {
            //        _selectedPriority = _projectIds.ElementAt(i);
            //        break;
            //    }
            //}
            _selectedPriority = priorityComboBox.SelectedIndex + 1;
        }

        private void handlerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedHandler = _projectMemberArrayList[handlerComboBox.SelectedIndex];
        }

        private void RefreshRequirementList()
        {

        }

        private async void GetUserListByProject()
        {
            //HttpResponseMessage response = await _presentationModel.GetUserListByProject(_project.ID.ToString());
            HttpResponseMessage response = await _presentationModel.GetUserListByProject(_requirement.ProjectID.ToString());
            string content = await response.Content.ReadAsStringAsync();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                JObject json = JObject.Parse(content);
                string message = json["result"].ToString();
                JArray jsonArray = JArray.Parse(json["users"].ToString());
                if (message == "success")
                {
                    handlerComboBox.Items.Clear();
                    _projectMemberArrayList.Clear();
                    for (int i = 0; i < jsonArray.Count; i++)
                    {
                        JObject jObject = jsonArray[i] as JObject;
                        handlerComboBox.Items.Add(new Item(Int32.Parse(jObject["id"].ToString()), jObject["name"].ToString()));
                        _projectMemberArrayList.Add(Int32.Parse(jObject["id"].ToString()));
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

        public UserInterfaceForm.FunctionalType GetFunctionalType()
        {
            return UserInterfaceForm.FunctionalType.Hide;
        }
    }
}
