using Newtonsoft.Json.Linq;
using RMS_Project;
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
    public partial class ProjectMainForm : Form, FunctionalTypeInterface
    {
        private PresentationModel _presentationModel;
        private Project _project;
        private UserInterfaceForm.FunctionalType type;

        public ProjectMainForm(PresentationModel presentationModel, Project project)
        {
            InitializeComponent();
            this._presentationModel = presentationModel;
            RefreshProjectDetail(project);
            type = UserInterfaceForm.FunctionalType.Hide;
            CheckPriority();
        }
        
        private void noFocusCueButton1_MouseMove(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            button.ForeColor = Color.CornflowerBlue;
            button.Image = _presentationModel.ChangeColor(new Bitmap(button.Image), Color.CornflowerBlue);
        }

        private void noFocusCueButton1_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.Image = _presentationModel.ChangeColor(new Bitmap(button.Image), Color.Black);
            button.ForeColor = Color.Black;
        }

        private void memberButton_Click(object sender, EventArgs e)
        {
            UserListForm userListForm = new UserListForm(_presentationModel, _project);
            if (_presentationModel.AddFormToPanel(userListForm))
            {
                _presentationModel.AddFormButtonToUserInterface(userListForm, "Members", Properties.Resources.ios7_people_outline);
            }
        }

        private void requirementButton_Click(object sender, EventArgs e)
        {
            RequirementListForm requirementListForm = new RequirementListForm(_presentationModel, _project);
            if (_presentationModel.AddFormToPanel(requirementListForm))
            {
                _presentationModel.AddFormButtonToUserInterface(requirementListForm, "Requirements", Properties.Resources.ios7_paper_outline);
            }
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            TestListForm testListForm = new TestListForm(_presentationModel, _project);
            if (_presentationModel.AddFormToPanel(testListForm))
            {
                _presentationModel.AddFormButtonToUserInterface(testListForm, "Test Cases", Properties.Resources.ios7_browsers_outline);
            }
        }

        public void RefreshProjectDetail(Project project)
        {
            this._project = project;
            _nameLabel.Text = project.NAME;
            _descriptionText.Text = project.DESC;
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

        private void othersButton_Click(object sender, EventArgs e)
        {
            TraceabilityMatrixForm traceabilityMatrixForm = new TraceabilityMatrixForm(_presentationModel, _project);
            if (_presentationModel.AddFormToPanel(traceabilityMatrixForm))
            {
                _presentationModel.AddFormButtonToUserInterface(traceabilityMatrixForm, "Others", Properties.Resources.ios7_gear_outline);
            }
        }

        private async void CheckPriority()
        {
            JObject jObject = await _presentationModel.GetPriority(_project.ID);
            if (jObject["priority_type_name"].ToString().Equals("Owner"))
            {
                type = UserInterfaceForm.FunctionalType.Edit;
                _presentationModel.SetFunctionalButton(type);
            }
        }
    }
}
