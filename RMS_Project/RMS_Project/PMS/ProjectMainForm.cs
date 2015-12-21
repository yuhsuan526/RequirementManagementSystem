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
    public partial class ProjectMainForm : Form
    {
        private PresentationModel _presentationModel;
        private Project _project;

        public ProjectMainForm(PresentationModel presentationModel, Project project)
        {
            InitializeComponent();
            this._presentationModel = presentationModel;
            RefreshProjectDetail(project);
        }
        
        private void noFocusCueButton1_MouseMove(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            button.Image = _presentationModel.ChangeColor(new Bitmap(button.Image), Color.CornflowerBlue);
        }

        private void noFocusCueButton1_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.Image = _presentationModel.ChangeColor(new Bitmap(button.Image), Color.Black);
        }

        private void projectButton_Click(object sender, EventArgs e)
        {
            /*
            UserInterfaceForm form = _presentationModel.UserInterface;
            if (_projectDetailForm.AddFormToPanel(_projectDetailForm))
            {
                if (form != null)
                {
                    form.SetFeatureButton(UserInterfaceForm.FeatureType.Edit);
                }
                ChangeTabType(projectButton);
            }*/
        }

        private void memberButton_Click(object sender, EventArgs e)
        {
            UserInterfaceForm form = _presentationModel.UserInterface;
            UserListForm userListForm = new UserListForm(_presentationModel, _project);
            if (_presentationModel.AddFormToPanel(userListForm))
            {
                _presentationModel.AddFormButtonToUserInterface(userListForm, "Members", Properties.Resources.ios7_people_outline);
                if (form != null)
                {
                    form.SetFeatureButton(UserInterfaceForm.FeatureType.Hide);
                }
                //ChangeTabType(memberButton);
            }
        }

        private void requirementButton_Click(object sender, EventArgs e)
        {
            UserInterfaceForm form = _presentationModel.UserInterface;
            RequirementListForm requirementListForm = new RequirementListForm(_presentationModel, _project);
            if (_presentationModel.AddFormToPanel(requirementListForm))
            {
                _presentationModel.AddFormButtonToUserInterface(requirementListForm, "Requirements", Properties.Resources.ios7_paper_outline);
                if (form != null)
                {
                    form.SetFeatureButton(UserInterfaceForm.FeatureType.New);
                }
                //ChangeTabType(requirementButton);
            }
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            UserInterfaceForm form = _presentationModel.UserInterface;
            TestListForm testListForm = new TestListForm(_presentationModel, _project);
            if (_presentationModel.AddFormToPanel(testListForm))
            {
                _presentationModel.AddFormButtonToUserInterface(testListForm, "Tests", Properties.Resources.ios7_browsers_outline);
                if (form != null)
                {
                    form.SetFeatureButton(UserInterfaceForm.FeatureType.New);
                }
                //ChangeTabType(testButton);
            }
        }

        private void SetButtonColor(Button button)
        {
            button.Image = _presentationModel.ChangeColor(new Bitmap(button.Image), Color.CornflowerBlue);
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
    }
}
