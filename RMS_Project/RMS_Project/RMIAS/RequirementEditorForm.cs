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
        private NormalAttribute _selectedType;
        private NormalAttribute _selectedStatus;
        private NormalAttribute _selectedPriority;
        private User _selectedHandler;

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

            _selectedHandler = new User();
            _selectedType = new NormalAttribute();
            _selectedPriority = new NormalAttribute();
            _selectedStatus = new NormalAttribute();

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

            _selectedHandler = new User();
            _selectedType = new NormalAttribute();
            _selectedPriority = new NormalAttribute();
            _selectedStatus = new NormalAttribute();

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
            typeComboBox.SelectedItem = _requirement.Type.Name;
            versionLabel.Text = (Int32.Parse(_requirement.Version) + 1).ToString();
            priorityComboBox.SelectedItem = _requirement.Priority.Name;
            statusComboBox.SelectedItem = _requirement.Status.Name;
            handlerComboBox.Text = _requirement.Handler.Name;
            DescriptionRichTextBox.Text = _requirement.Description;
            MemoRichTextBox.Text = _requirement.Memo;
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            if (_requirement == null)
                AddRequirementToProject();
            else
            {
                _requirement.Name = nameTextBox.Text;
                _requirement.Handler = _selectedHandler;
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
            jObject["handler"] = _selectedHandler.ID;
            jObject["uid"] = _presentationModel.GetUID();
            jObject["pid"] = _project.ID;
            jObject["requirement_type_id"] = _selectedType.ID;
            jObject["priority_type_id"] = _selectedPriority.ID;
            jObject["status_type_id"] = _selectedStatus.ID;

            string status = await _presentationModel.AddRequirement(jObject);
            if (status == "success")
            {
                MessageBox.Show("需求建立成功", "Success", MessageBoxButtons.OK);
                RequirementListForm form = _presentationModel.GetFormByType(typeof(RequirementListForm)) as RequirementListForm;
                form.RefreshRequirementList();
                _presentationModel.PopFormFromPanel();
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

        private async void EditRequirement()
        {
            string message = await _presentationModel.EditRequirement(_requirement);
            try
            {
                MessageBox.Show(message, "Success", MessageBoxButtons.OK);
                RequirementDetailForm form = _presentationModel.GetFormByType(typeof(RequirementDetailForm)) as RequirementDetailForm;
                form.RefreshRequirementDetail(_requirement);
                _presentationModel.PopFormFromPanel();
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
                int tempIndex = 0;
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
                        {
                            priorityComboBox.Items.Add(new Item(_projectIds.ElementAt(i), _projectNames.ElementAt(i)));
                            if (_requirement != null)
                            {
                                if (_projectIds.ElementAt(i) == _requirement.Priority.ID)
                                    tempIndex = i;
                            }
                        }
                        if (priorityComboBox.Items.Count > 0)
                        {
                            if (_requirement != null)
                                priorityComboBox.SelectedItem = priorityComboBox.Items[tempIndex];
                            else
                                priorityComboBox.SelectedItem = priorityComboBox.Items[0];
                        }
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
                        {
                            typeComboBox.Items.Add(new Item(_requireIds.ElementAt(i), _requireNames.ElementAt(i)));
                            if (_requirement != null)
                            {
                                if (_requireIds.ElementAt(i) == _requirement.Type.ID)
                                    tempIndex = i;
                            }
                        }
                        if (typeComboBox.Items.Count > 0)
                        {
                            if (_requirement != null)
                                typeComboBox.SelectedItem = typeComboBox.Items[tempIndex];
                            else
                                typeComboBox.SelectedItem = typeComboBox.Items[0];
                        }
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
                        {
                            statusComboBox.Items.Add(new Item(_statusIds.ElementAt(i), _statusNames.ElementAt(i)));
                            if (_requirement != null)
                            {
                                if (_statusIds.ElementAt(i) == _requirement.Status.ID)
                                    tempIndex = i;
                            }
                        }
                        if (statusComboBox.Items.Count > 0)
                        {
                            if (_requirement != null)
                                statusComboBox.SelectedItem = statusComboBox.Items[tempIndex];
                            else
                                statusComboBox.SelectedItem = statusComboBox.Items[0];
                        }
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
            _selectedType.ID = typeComboBox.SelectedIndex + 1;
            _selectedType.Name = typeComboBox.SelectedItem.ToString();
        }

        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedStatus.ID = statusComboBox.SelectedIndex + 1;
            _selectedStatus.Name = statusComboBox.SelectedItem.ToString();
        }

        private void priorityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedPriority.ID = priorityComboBox.SelectedIndex + 1;
            _selectedPriority.Name = priorityComboBox.SelectedItem.ToString();
        }

        private void handlerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedHandler.ID = _projectMemberArrayList[handlerComboBox.SelectedIndex];
            _selectedHandler.Name = handlerComboBox.SelectedItem.ToString();
        }

        private async void GetUserListByProject()
        {
            HttpResponseMessage response;
            if (_project != null)
                response = await _presentationModel.GetUserListByProject(_project.ID.ToString());
            else if (_requirement != null)
                response = await _presentationModel.GetUserListByProject(_requirement.ProjectID.ToString());
            else
                throw new Exception("需求不可以為null");
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
                    int tempIndex = 0;
                    for (int i = 0; i < jsonArray.Count; i++)
                    {
                        JObject jObject = jsonArray[i] as JObject;
                        handlerComboBox.Items.Add(new Item(Int32.Parse(jObject["id"].ToString()), jObject["name"].ToString()));
                        _projectMemberArrayList.Add(Int32.Parse(jObject["id"].ToString()));
                        if (_requirement != null)
                        {
                            if (Int32.Parse(jObject["id"].ToString()) == _requirement.Handler.ID)
                                tempIndex = i;
                        }
                    }
                    if (handlerComboBox.Items.Count > 0)
                    {
                        if (_requirement != null)
                            handlerComboBox.SelectedItem = handlerComboBox.Items[tempIndex];
                        else
                            handlerComboBox.SelectedItem = handlerComboBox.Items[0];
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
