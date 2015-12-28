using Newtonsoft.Json.Linq;
using System;
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
    public partial class ProjectEditorForm : Form, FunctionalTypeInterface
    {
        private PresentationModel _presentationModel;
        private Project _project;

        public ProjectEditorForm(PresentationModel presentationModel)
        {
            InitializeComponent();
            this._presentationModel = presentationModel;
        }

        public ProjectEditorForm(PresentationModel presentationModel, Project project)
        {
            InitializeComponent();
            this._presentationModel = presentationModel;
            this._project = project;
            nameTextBox.Text = _project.NAME;
            descriptionRichTextBox.Text = _project.DESC;
        }

        private void modifyProjectButton_Click(object sender, EventArgs e)
        {
            if (_project == null) {
                AddProject();
            }
            else {
                _project.NAME = nameTextBox.Text;
                _project.DESC = descriptionRichTextBox.Text;
                EditProject();
            }
        }

        private async void AddProject()
        {
            JObject jObject = new JObject();
            jObject["name"] = nameTextBox.Text;
            jObject["description"] = descriptionRichTextBox.Text;
            jObject["uid"] = _presentationModel.GetUID();

            string status = await _presentationModel.AddProject(jObject);
            if (status == "success")
            {
                ProjectListForm form = _presentationModel.GetFormByType(typeof(ProjectListForm)) as ProjectListForm;
                form.RefreshProjectList();
                _presentationModel.PopFormFromPanel();
                MessageBox.Show("專案建立成功", "Success", MessageBoxButtons.OK);
            }
            else if (status == "專案建立失敗")
            {
                MessageBox.Show("專案建立失敗", "Error", MessageBoxButtons.OK);
            }
            else if (status == "伺服器無回應")
            {
                MessageBox.Show("伺服器無回應", "Error", MessageBoxButtons.OK);
            }
        }

        private async void EditProject()
        {
            string message = await _presentationModel.EditProject(_project);
            try
            {
                ProjectMainForm form = _presentationModel.GetFormByType(typeof(ProjectMainForm)) as ProjectMainForm;
                form.RefreshProjectDetail(_project);
                _presentationModel.PopFormFromPanel();
                MessageBox.Show(message, "Success", MessageBoxButtons.OK);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK);
            }
        }


        public UserInterfaceForm.FunctionalType GetFunctionalType()
        {
            return UserInterfaceForm.FunctionalType.Hide;
        }
    }
}
