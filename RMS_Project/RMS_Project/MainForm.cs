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
    public partial class MainForm : Form
    {
        private UserInterfaceForm userInterface;

        public MainForm()
        {
            InitializeComponent();
            AddFormToPanel(new LoginForm(this));
        }

        public void AddFormToPanel(Form form)
        {
            form.TopLevel = false;
            while (mainFormPanel.Controls.Count > 0)
                mainFormPanel.Controls.RemoveAt(0);
            mainFormPanel.Controls.Add(form);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        public void AddFormToNavigationPanel(Form form)
        {
            form.TopLevel = false;
            while (navigationPanel.Controls.Count > 0)
                navigationPanel.Controls.RemoveAt(0);
            navigationPanel.Controls.Add(form);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        public void SetUserInterfaceForm(UserInterfaceForm form)
        {
            this.userInterface = form;
        }

        public void AddFormButtonToUserInterface(Form form, string name, Image image)
        {
            if (this.userInterface != null)
                this.userInterface.AddFormButtonToBar(form, name, image);
        }
    }
}
