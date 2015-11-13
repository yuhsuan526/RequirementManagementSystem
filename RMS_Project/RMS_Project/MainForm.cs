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
        private int accountId;
        private string username;
        public static string BASE_URL = "http://140.124.183.32:3000/";

        public MainForm()
        {
            InitializeComponent();
            AddFormToPanel(new LoginForm(this));
            AddFormToNavigationPanel(new DefaultInterfaceForm());
        }

        public int UID
        {
            get
            {
                return accountId;
            }
        }

        public string Username
        {
            get
            {
                return username;
            }
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

        public void AddFormButtonToUserInterface(Form form, string name, Image image)
        {
            if (this.userInterface != null)
                this.userInterface.AddFormButtonToBar(form, name, image);
        }

        public void SignIn(int uid, string name)
        {
            this.accountId = uid;
            this.username = name;
            AddFormToPanel(new ProjectListForm(this));
            UserInterfaceForm form = new UserInterfaceForm(this);
            AddFormToNavigationPanel(form);
            this.userInterface = form;
        }

        public void SignOut()
        {
            this.accountId = -1;
            this.username = "";
            AddFormToPanel(new LoginForm(this));
            AddFormToNavigationPanel(new DefaultInterfaceForm());
            this.userInterface = null;
        }
    }
}
