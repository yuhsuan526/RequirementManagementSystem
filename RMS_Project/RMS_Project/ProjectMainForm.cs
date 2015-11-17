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
    public partial class ProjectMainForm : Form
    {
        MainForm mainForm;
        Project project;
        private ProjectDetailForm projectDetailForm;
        private RequirementListForm requirementListForm;
        private UserListForm userListForm;
        private RequirementEditorForm requirementEditorForm;
        private Button currentActiveButton = null;

        public ProjectMainForm(MainForm mainForm, Project project)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.project = project;
            projectDetailForm = new ProjectDetailForm(project);
            requirementListForm = new RequirementListForm(project);
            userListForm = new UserListForm(mainForm, project);
            requirementEditorForm = new RequirementEditorForm(mainForm,project);
            AddFormToPanel(projectDetailForm);
            UserInterfaceForm form = mainForm.GetUserInterface();
            if (form != null)
            {
                form.SetFeatureButton(UserInterfaceForm.FeatureType.Edit);
            }
            currentActiveButton = projectButton;
            SetButtonColor(projectButton);
        }

        public void AddFormToPanel(Form form)
        {
            form.TopLevel = false;
            while (mainPanel.Controls.Count > 0)
                mainPanel.Controls.RemoveAt(mainPanel.Controls.Count - 1);
            mainPanel.Controls.Add(form);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        public void ClickNewButton()
        {
            if (currentActiveButton == projectButton)
            {

            }
            else if (currentActiveButton == memberButton)
            {

            }
            else if (currentActiveButton == requirementButton)
            {
                AddFormToPanel(requirementEditorForm);
            }
            else if (currentActiveButton == testButton)
            {

            }
        }
        
        private void noFocusCueButton1_MouseMove(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            button.Image = MainForm.ChangeColor(new Bitmap(button.Image), Color.CornflowerBlue);
        }

        private void noFocusCueButton1_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.Image = MainForm.ChangeColor(new Bitmap(button.Image), Color.Black);
            if (currentActiveButton != button)
                button.Image = MainForm.ChangeColor(new Bitmap(button.Image), Color.Black);
        }

        private void projectButton_Click(object sender, EventArgs e)
        {
            UserInterfaceForm form = mainForm.GetUserInterface();
            AddFormToPanel(projectDetailForm);
            if (form != null)
            {
                form.SetFeatureButton(UserInterfaceForm.FeatureType.Edit);
            }
            ChangeTabType(projectButton);
        }

        private void memberButton_Click(object sender, EventArgs e)
        {
            UserInterfaceForm form = mainForm.GetUserInterface();
            AddFormToPanel(userListForm);
            if (form != null)
            {
                //form.SetFeatureButton(UserInterfaceForm.FeatureType.New);
                form.SetFeatureButton(UserInterfaceForm.FeatureType.Hide);
            }
            ChangeTabType(memberButton);
        }

        private void requirementButton_Click(object sender, EventArgs e)
        {
            UserInterfaceForm form = mainForm.GetUserInterface();
            AddFormToPanel(requirementListForm);
            if (form != null)
            {
                form.SetFeatureButton(UserInterfaceForm.FeatureType.New);
            }
            ChangeTabType(requirementButton);
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            UserInterfaceForm form = mainForm.GetUserInterface();
            if (form != null)
            {
                form.SetFeatureButton(UserInterfaceForm.FeatureType.New);
            }
            ChangeTabType(testButton);
        }

        private void SetButtonColor(Button button)
        {
            button.Image = MainForm.ChangeColor(new Bitmap(button.Image), Color.CornflowerBlue);
        }

        private void ResetOtherButtonColor()
        {
            if (currentActiveButton != projectButton)
            {
                projectButton.Image = MainForm.ChangeColor(new Bitmap(projectButton.Image), Color.Black);
            }
            if (currentActiveButton != memberButton)
            {
                memberButton.Image = MainForm.ChangeColor(new Bitmap(memberButton.Image), Color.Black);
            }
            if (currentActiveButton != requirementButton)
            {
                requirementButton.Image = MainForm.ChangeColor(new Bitmap(requirementButton.Image), Color.Black);
            }
            if (currentActiveButton != testButton)
            {
                testButton.Image = MainForm.ChangeColor(new Bitmap(testButton.Image), Color.Black);
            }
        }

        private void ChangeTabType(Button button)
        {
            currentActiveButton = button;
            ResetOtherButtonColor();
        }
    }

    public class Project
    {
        public Project(int id, string name, string description)
        {
            this.id = id;
            this.name = name;
            this.description = description;
        }
        public int id;
        public string name;
        public string description;
    }
}
