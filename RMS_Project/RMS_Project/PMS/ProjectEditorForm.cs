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
        }

        private void modifyProjectButton_Click(object sender, EventArgs e)
        {
            AddProject();
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

        public UserInterfaceForm.FunctionalType GetFunctionalType()
        {
            return UserInterfaceForm.FunctionalType.Hide;
        }
    }
}
