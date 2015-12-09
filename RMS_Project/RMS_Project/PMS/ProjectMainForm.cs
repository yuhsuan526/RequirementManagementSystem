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
    public partial class ProjectMainForm : BasicForm
    {
        private PresentationModel _presentationModel;
        private Project _project;
        private ProjectDetailForm _projectDetailForm;
        private RequirementListForm _requirementListForm;
        private TestListForm _testListForm;
        private UserListForm _userListForm;
        private RequirementEditorForm _requirementEditorForm;
        private Button _currentActiveButton = null;

        public ProjectMainForm(PresentationModel presentationModel, Project project, Panel panel) : base(panel)
        {
            InitializeComponent();
            this._presentationModel = presentationModel;
            this._project = project;

            _projectDetailForm = new ProjectDetailForm(project, _mainPanel);
            _requirementListForm = new RequirementListForm(_presentationModel, project, panel);
            _testListForm = new TestListForm(_presentationModel, project, panel);
            _userListForm = new UserListForm(_presentationModel, project, panel);
            _requirementEditorForm = new RequirementEditorForm(_presentationModel, project);

            _projectDetailForm.AddForm(_projectDetailForm);

            UserInterfaceForm form = _presentationModel.UserInterface;
            if (form != null)
            {
                form.SetFeatureButton(UserInterfaceForm.FeatureType.Edit);
            }
            _currentActiveButton = projectButton;
            SetButtonColor(projectButton);
        }

        public void ClickNewButton()
        {
            if (_currentActiveButton == projectButton)
            {

            }
            else if (_currentActiveButton == memberButton)
            {

            }
            else if (_currentActiveButton == requirementButton)
            {
                AddForm(_requirementEditorForm);
            }
            else if (_currentActiveButton == testButton)
            {

            }
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
            if (_currentActiveButton != button)
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
            if (_userListForm.AddForm(_userListForm))
            {
                _presentationModel.AddFormButtonToUserInterface(_userListForm, "Members", Properties.Resources.ios7_people_outline);
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
            if (_requirementListForm.AddForm(_requirementListForm))
            {
                _presentationModel.AddFormButtonToUserInterface(_requirementListForm, "Requirements", Properties.Resources.ios7_paper_outline);
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
            if (_testListForm.AddForm(_testListForm))
            {
                _presentationModel.AddFormButtonToUserInterface(_testListForm, "Tests", Properties.Resources.ios7_browsers_outline);
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

        private void ResetOtherButtonColor()
        {
            if (_currentActiveButton != projectButton)
            {
                projectButton.Image = _presentationModel.ChangeColor(new Bitmap(projectButton.Image), Color.Black);
            }
            if (_currentActiveButton != memberButton)
            {
                memberButton.Image = _presentationModel.ChangeColor(new Bitmap(memberButton.Image), Color.Black);
            }
            if (_currentActiveButton != requirementButton)
            {
                requirementButton.Image = _presentationModel.ChangeColor(new Bitmap(requirementButton.Image), Color.Black);
            }
            if (_currentActiveButton != testButton)
            {
                testButton.Image = _presentationModel.ChangeColor(new Bitmap(testButton.Image), Color.Black);
            }
        }

        private void ChangeTabType(Button button)
        {
            _currentActiveButton = button;
            ResetOtherButtonColor();
        }
    }
}
