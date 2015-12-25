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

        public RequirementListForm(PresentationModel presentationModel, Project project)
        {
            InitializeComponent();
            this._presentationModel = presentationModel;
            this._project = project;
            this.requirementListDataGridView.ClearSelection();
            _arrayList = new ArrayList();
            GetRequirementByProject();
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
                    this.requirementListDataGridView.Rows.Clear();
                    foreach (JObject jObject in jsonArray)
                    {
                        this.requirementListDataGridView.Rows.Add(jObject["name"], jObject["updated_at"]);
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
                RefreshRequirementList();
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
                if (_presentationModel.AddFormToPanel(form))
                    _presentationModel.AddFormButtonToUserInterface(form, "Add Comment", Properties.Resources.ios7_compose_outline);
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

        void deleteButton_Click(object sender, EventArgs e)
        {

        }

        public async void RefreshRequirementList()
        {
            try
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
                        this.requirementListDataGridView.Rows.Clear();
                        _arrayList = new ArrayList();
                        foreach (JObject jObject in jsonArray)
                        {
                            this.requirementListDataGridView.Rows.Add(jObject["name"]);
                            JObject jOwner = jObject["owner"] as JObject;
                            JObject jHandler = jObject["handler"] as JObject;
                            JObject jType = jObject["requirement_type"] as JObject;
                            JObject jPriority = jObject["priority_type"] as JObject;
                            JObject jStatus = jObject["status_type"] as JObject;
                            User owner = _presentationModel.getUser((int)jOwner["id"], jOwner["name"].ToString());
                            User handler = _presentationModel.getUser((int)jHandler["id"], jHandler["name"].ToString());
                            NormalAttribute type = _presentationModel.getRequirementAttribute((int)jType["id"], jType["name"].ToString());
                            NormalAttribute priority = _presentationModel.getRequirementAttribute((int)jPriority["id"],jPriority["name"].ToString());
                            NormalAttribute status = _presentationModel.getRequirementAttribute((int)jStatus["id"], jStatus["name"].ToString());
                            Requirement requirement = new Requirement((int)jObject["id"], _project.ID, jObject["name"].ToString(), owner, handler,
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
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK);
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
            return UserInterfaceForm.FunctionalType.New;
        }
    }
}
