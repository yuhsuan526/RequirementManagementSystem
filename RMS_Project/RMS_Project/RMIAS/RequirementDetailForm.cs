using System;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;

namespace RMS_Project
{
    public partial class RequirementDetailForm : Form, FunctionalTypeInterface
    {
        private PresentationModel _presentationModel;
        private Requirement _requirement;
        private UserInterfaceForm.FunctionalType type;
        private bool isFinished;
        private const int OPEN_ID = 1;
        private const int APPROVED_ID = 3;
        private const int FINISHED_ID = 5;

        public RequirementDetailForm(PresentationModel presentationModel, Requirement requirement)
        {
            InitializeComponent();
            _presentationModel = presentationModel;
            type = UserInterfaceForm.FunctionalType.Hide;
            RefreshRequirementDetail(requirement);
        }

        public void RefreshRequirementDetail(Requirement requirement)
        {
            this._requirement = requirement;
            idLabel.Text = _requirement.ID.ToString();
            nameLabel.Text = _requirement.Name;
            versionLabel.Text = _requirement.Version;
            typeLabel.Text = _requirement.Type.Name;
            priorityLabel.Text = _requirement.Priority.Name;
            statusLabel.Text = _requirement.Status.Name;
            requirementOwnerLabel.Text = _requirement.Owner.Name;
            handlerLabel.Text = _requirement.Handler.Name;
            descriptionTextBox.Text = _requirement.Description;
            memoTextBox.Text = _requirement.Memo;
            isFinished = false;
            if (requirement.Handler.ID == _presentationModel.GetUID() &&
                (requirement.Status.ID == APPROVED_ID || requirement.Status.ID == FINISHED_ID))
            {
                _finishButton.Enabled = true;
            }
            else
            {
                _finishButton.Enabled = false;
            }
            if (requirement.Status.ID == FINISHED_ID)
            {
                _finishButton.Image = Properties.Resources.ios7_checkmark_outline;
                _finishButton.Text = "Finished";
                isFinished = true;
            }
            else
            {
                _finishButton.Image = Properties.Resources.ios7_circle_outline;
                _finishButton.Text = "Unfinished";
                isFinished = false; ;
            }
            getTestcaseByRequirementId();
            getComment();
            CheckPriority();
        }

        public Requirement Requirement
        {
            get
            {
                return _requirement;
            }
        }

        public UserInterfaceForm.FunctionalType GetFunctionalType()
        {
            return type;
        }

        private async void getTestcaseByRequirementId()
        {
            HttpResponseMessage response = await _presentationModel.GetTestCaseListByRequirementId(_requirement.ID);
            string content = await response.Content.ReadAsStringAsync();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                _associatedTestListDataGridView.Rows.Clear();
                JObject json = JObject.Parse(content);
                string message = json["result"].ToString();
                JArray jsonArray = JArray.Parse(json["test_case_list"].ToString());
                if (message == "success")
                {
                    for (int i = 0; i < jsonArray.Count; i++)
                    {
                        JObject jObject = (JObject)jsonArray[i];
                        _associatedTestListDataGridView.Rows.Add(jObject["name"].ToString());
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

        private async void getComment()
        {
            HttpResponseMessage response = await _presentationModel.GetCommentByRequirement(_requirement.ID);
            string content = await response.Content.ReadAsStringAsync();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                JObject json = JObject.Parse(content);
                string message = json["result"].ToString();
                JArray jsonArray = JArray.Parse(json["comment_list"].ToString());
                if (message == "success")
                {
                    this._commentDataGridView.Rows.Clear();
                    foreach (JObject jObject in jsonArray)
                    {
                        JObject jOwner = jObject["user"] as JObject;
                        User owner = _presentationModel.getUser((int)jOwner["id"], jOwner["name"].ToString());
                        this._commentDataGridView.Rows.Add(owner.Name, jObject["comment"], jObject["decision"]);
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

        private async void CheckPriority()
        {
            JObject jObject = await _presentationModel.GetPriority(_requirement.ProjectID);
            if (jObject["priority_type_name"].ToString().Equals("Owner") ||
                jObject["priority_type_name"].ToString().Equals("Manager"))
            {
                type = UserInterfaceForm.FunctionalType.Edit;
                _presentationModel.SetFunctionalButton(type);
            }
            else if (jObject["priority_type_name"].ToString().Equals("Customer"))
            {
                if (_requirement.Status.ID == OPEN_ID && _requirement.Owner.ID == _presentationModel.GetUID())
                {
                    type = UserInterfaceForm.FunctionalType.Edit;
                    _presentationModel.SetFunctionalButton(type);
                }
            }
        }

        private void _finishButton_MouseLeave(object sender, EventArgs e)
        {
            _finishButton.ForeColor = Color.Black;
            _finishButton.Image = _presentationModel.ChangeColor(new Bitmap(_finishButton.Image), Color.Black);
        }

        private void _finishButton_MouseMove(object sender, MouseEventArgs e)
        {
            _finishButton.ForeColor = Color.CornflowerBlue;
            _finishButton.Image = _presentationModel.ChangeColor(new Bitmap(_finishButton.Image), Color.CornflowerBlue);
        }

        private void _finishButton_Click(object sender, EventArgs e)
        {
            if (isFinished == false)
            {
                _requirement.Status = new NormalAttribute(5,"Finished");
            }
            else
            {
                _requirement.Status = new NormalAttribute(3,"Approved");
            }
            EditRequirement();
        }

        private async void EditRequirement()
        {
            string message = await _presentationModel.EditRequirement(_requirement);
            try
            {
                RefreshRequirementDetail(_requirement);
                RequirementListForm form = _presentationModel.GetFormByType(typeof(RequirementListForm)) as RequirementListForm;
                form.GetRequirementByProject();
                MessageBox.Show(message, "Success", MessageBoxButtons.OK);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK);
            }
        }
    }
}
