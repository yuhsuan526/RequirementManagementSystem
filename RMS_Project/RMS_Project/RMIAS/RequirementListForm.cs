using Newtonsoft.Json;
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
    public partial class RequirementListForm : Form, FunctionalTypeInterface
    {
        private PresentationModel _presentationModel;
        private Project _project;
        private ArrayList _arrayList;
        private UserInterfaceForm.FunctionalType type;

        public RequirementListForm(PresentationModel presentationModel, Project project)
        {
            InitializeComponent();
            this._presentationModel = presentationModel;
            this._project = project;
            this.requirementListDataGridView.ClearSelection();
            type = UserInterfaceForm.FunctionalType.Hide;
            _arrayList = new ArrayList();
            requirementListDataGridView.Columns[2].Visible = false;
            requirementListDataGridView.Columns[3].Visible = false;
            GetRequirementByProject();
            CheckPriority();
        }

        public async void GetRequirementByProject()
        {
            HttpResponseMessage response = await _presentationModel.GetRequirementByProject(_project.ID.ToString());
            string content = await response.Content.ReadAsStringAsync();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                JObject json = JObject.Parse(content);
                string message = json["result"].ToString();
                _arrayList = new ArrayList();
                JArray jsonArray = JArray.Parse(json["requirements"].ToString());
                if (message == "success")
                {
                    this.requirementListDataGridView.Rows.Clear();
                    foreach (JObject jObject in jsonArray)
                    {
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
                        Requirement requirement = new Requirement((int)jObject["id"], _project.ID, jObject["name"].ToString(), owner, handler,
                            jObject["description"].ToString(), jObject["version"].ToString(), jObject["memo"].ToString(),
                            type, priority, status);
                        this.requirementListDataGridView.Rows.Add(jObject["name"], status.Name);
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

        public async void DeleteRequirement(int requirementId)
        {
            try
            {
                string message = await _presentationModel.DeleteRequirement(requirementId);
                GetRequirementByProject();
                MessageBox.Show(message, "Success", MessageBoxButtons.OK);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void requirementListDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] == _deleteColumn)
            {
                Requirement requirement = _arrayList[e.RowIndex] as Requirement;
                DeleteRequirement(requirement.ID);
            }
            else if (senderGrid.Columns[e.ColumnIndex] == _commentColumn)
            {
                Requirement requirement = _arrayList[e.RowIndex] as Requirement;
                CommentEditorForm form = new CommentEditorForm(_presentationModel, requirement);
                _presentationModel.AddFormToPanel(form);
            }
            else
            {
                DataGridViewCell cell = requirementListDataGridView.Rows[e.RowIndex].Cells[0];
                Requirement requirement = _arrayList[e.RowIndex] as Requirement;
                Form form = new RequirementDetailForm(_presentationModel, requirement);
                if (_presentationModel.AddFormToPanel(form))
                    _presentationModel.AddFormButtonToUserInterface(form, cell.Value.ToString(), Properties.Resources.ios7_paper_outline);
            }
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
            return type;
        }

        private async void CheckPriority()
        {
            JObject jObject = await _presentationModel.GetPriority(_project.ID);
            if (jObject["priority_type_name"].ToString().Equals("Owner") ||
                jObject["priority_type_name"].ToString().Equals("Manager"))
            {
                type = UserInterfaceForm.FunctionalType.New;
                requirementListDataGridView.Columns[2].Visible = true;
                requirementListDataGridView.Columns[3].Visible = true;
                _presentationModel.SetFunctionalButton(type);
            }
            else if (jObject["priority_type_name"].ToString().Equals("Customer") )
            {
                type = UserInterfaceForm.FunctionalType.New;
                _presentationModel.SetFunctionalButton(type);
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            this.requirementListDataGridView.Rows.Clear();
            foreach (Requirement requirement in _arrayList)
            {
                if (requirement.Name.Contains(searchTextBox.Text.ToString()))
                {
                    this.requirementListDataGridView.Rows.Add(requirement.Name, requirement.Status.Name);
                }
            }
        }
    }
}
