using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS_Project
{
    public partial class CommentEditorForm : Form, FunctionalTypeInterface
    {
        private Requirement _requirement;
        private PresentationModel _presentationModel;

        public CommentEditorForm(PresentationModel presentationModel, Requirement requirement)
        {
            InitializeComponent();
            _requirement = requirement;
            _presentationModel = presentationModel;
            _requirementLabel.Text = requirement.Name;
            _ownerLabel.Text = _presentationModel.GetUserName();
        }

        public UserInterfaceForm.FunctionalType GetFunctionalType()
        {
            return UserInterfaceForm.FunctionalType.Hide;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {

            AddComment();
        }

        private async void AddComment()
        {
            JObject jObject = new JObject();
            jObject["rid"] = _requirement.ID;
            jObject["uid"] = _presentationModel.GetUID();
            jObject["comment"] = _commentRichTextBox.Text;
            jObject["decision"] = _decisionRichTextBox.Text;

            string status = await _presentationModel.AddCommentToRequirement(jObject);
            if (status == "success")
            {
                MessageBox.Show("評論成功", "Success", MessageBoxButtons.OK);
                _presentationModel.PopFormFromPanel();
            }
            else if (status == "評論失敗")
            {
                MessageBox.Show("評論失敗", "Error", MessageBoxButtons.OK);
            }
            else if (status == "伺服器無回應")
            {
                MessageBox.Show("伺服器無回應", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
