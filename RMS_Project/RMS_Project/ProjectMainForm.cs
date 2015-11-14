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

        public ProjectMainForm(MainForm mainForm, Project project)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.project = project;
            projectDetailForm = new ProjectDetailForm(project);
            requirementListForm = new RequirementListForm(project);
            userListForm = new UserListForm(mainForm, project);
            AddFormToPanel(projectDetailForm);
            UserInterfaceForm form = mainForm.GetUserInterface();
            if (form != null)
            {
                form.SetFeatureButton(UserInterfaceForm.FeatureType.Edit);
            }
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
        }

        private void projectButton_Click(object sender, EventArgs e)
        {
            UserInterfaceForm form = mainForm.GetUserInterface();
            AddFormToPanel(projectDetailForm);
            if (form != null)
            {
                form.SetFeatureButton(UserInterfaceForm.FeatureType.Edit);
            }
        }

        private void memberButton_Click(object sender, EventArgs e)
        {
            UserInterfaceForm form = mainForm.GetUserInterface();
            AddFormToPanel(userListForm);
            if (form != null)
            {
                form.SetFeatureButton(UserInterfaceForm.FeatureType.New);
            }
        }

        private void requirementButton_Click(object sender, EventArgs e)
        {
            UserInterfaceForm form = mainForm.GetUserInterface();
            AddFormToPanel(requirementListForm);
            if (form != null)
            {
                form.SetFeatureButton(UserInterfaceForm.FeatureType.New);
            }
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            UserInterfaceForm form = mainForm.GetUserInterface();
            if (form != null)
            {
                form.SetFeatureButton(UserInterfaceForm.FeatureType.New);
            }
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
