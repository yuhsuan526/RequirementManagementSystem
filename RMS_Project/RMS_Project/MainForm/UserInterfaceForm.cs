using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS_Project
{
    public partial class UserInterfaceForm : Form
    {
        private PresentationModel _presentationModel;
        private ArrayList _buttonArrayList;
        private ProjectListForm _projectListForm;
        private ContextMenuStrip _contextMenuStrip;

        public enum FeatureType { New, Edit, Hide };

        public UserInterfaceForm(PresentationModel presentationModel)
        {
            InitializeComponent();
            this._presentationModel = presentationModel;
            _buttonArrayList = new ArrayList();
            addProjectButton();
            addUserMenu();
        }

        public void setProjectsButton(ProjectListForm form)
        {
            _projectListForm = form;
            _presentationModel.AddFormToPanel(_projectListForm);
        }

        //Add hierarchy button (project button)
        private void addProjectButton()
        {
            NoFocusCueButton projectsButton = GetItemButton();
            projectsButton.Text = "Projects";
            projectsButton.Margin = new Padding(10, 13, 0, 2);
            projectsButton.Image = Properties.Resources.ios7_briefcase_outline;
            projectsButton.Click += projectsButton_Click;
            flowLayoutPanel.Controls.Add(projectsButton);
        }

        //Add user menu
        private void addUserMenu()
        {
            _contextMenuStrip = new ContextMenuStrip();
            _contextMenuStrip.Items.Add("Edit account");
            _contextMenuStrip.Items.Add("Manage organizations");
            _contextMenuStrip.Items.Add("Help");
            _contextMenuStrip.Items.Add("Sign out");
            _contextMenuStrip.ShowImageMargin = false;
            _contextMenuStrip.ItemClicked += contextMenuStrip_ItemClicked;
        }

        void contextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Sign out")
            {
                _contextMenuStrip.Hide();
                _presentationModel.SignOut();
            }
        }

        void projectsButton_Click(object sender, EventArgs e)
        {
            if (_presentationModel.PopFormsFromPanel(_projectListForm))
            {
                for (int i = 0; i < _buttonArrayList.Count; i++)
                {
                    InterfaceModel model = (InterfaceModel)_buttonArrayList[i];
                    flowLayoutPanel.Controls.Remove(model.PictureBox);
                    flowLayoutPanel.Controls.Remove(model.Button);
                }
                SetFeatureButton(FeatureType.New);
                _buttonArrayList.Clear();
            }
        }

        public void SetFeatureButton(FeatureType type)
        {
            switch(type)
            {
                case FeatureType.New:
                    _functionalButton.Text = "New";
                    _functionalButton.Image = Properties.Resources.ios7_plus_outline;
                    _functionalButton.Visible = true;
                    break;
                case FeatureType.Edit:
                    _functionalButton.Text = "Edit";
                    _functionalButton.Image = Properties.Resources.edit;
                    _functionalButton.Visible = true;
                    break;
                case FeatureType.Hide:
                    _functionalButton.Visible = false;
                    break;
            }
        }

        public void AddFormButtonToBar(Form form, string buttonName, Image image)
        {
            InterfaceModel model = new InterfaceModel();
            model.Form = form;
            model.PictureBox = new PictureBox();
            model.PictureBox.Image = Properties.Resources.ios7_arrow_forward_small;
            model.PictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            model.PictureBox.Margin = new Padding(0, 30, 0, 0);
            model.Button = GetItemButton();
            model.Button.Image = image;
            model.Button.Text = buttonName;
            model.Button.Click += button_Click;
            flowLayoutPanel.Controls.Add(model.PictureBox);
            flowLayoutPanel.Controls.Add(model.Button);
            _buttonArrayList.Add(model);
        }

        void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            bool isAvailable = false;
            int i;
            for (i = 0; i < _buttonArrayList.Count; i++)
            {
                InterfaceModel model = (InterfaceModel)_buttonArrayList[i];
                if (model.Button == button)
                {
                    isAvailable = _presentationModel.PopFormsFromPanel(model.Form);
                    break;
                }
            }
            if (isAvailable)
            {
                for (int j = _buttonArrayList.Count - 1; j >= i + 1; j--)
                {
                    InterfaceModel model = (InterfaceModel)_buttonArrayList[j];
                    flowLayoutPanel.Controls.Remove(model.PictureBox);
                    flowLayoutPanel.Controls.Remove(model.Button);
                    _buttonArrayList.Remove(model);
                }
            }
        }

        private NoFocusCueButton GetItemButton()
        {
            
            NoFocusCueButton button = new NoFocusCueButton();
            button.Anchor = AnchorStyles.Left;
            button.ImageAlign = ContentAlignment.MiddleLeft;
            button.AutoSize = true;
            button.TextImageRelation = TextImageRelation.ImageBeforeText;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            button.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            button.FlatAppearance.BorderSize = 0;
            button.Margin = new Padding(0, 13, 0, 2);
            button.Font = new Font("Times New Roman", 16);
            return button;
        }

        private void functionalButton_Click(object sender, EventArgs e)
        {
            _presentationModel.ClickFunctionalButton();
        }

        private void functionalButton_MouseLeave(object sender, EventArgs e)
        {
            _functionalButton.ForeColor = Color.Black;
            _functionalButton.Image = _presentationModel.ChangeColor(new Bitmap(_functionalButton.Image), Color.Black);
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            _contextMenuStrip.Show(_userButton, new Point(_userButton.Width / 2, (int)(_userButton.Height * 0.7f)));
        }

        private void userButton_MouseLeave(object sender, EventArgs e)
        {
            _userButton.ForeColor = Color.Black;
            _userButton.Image = _presentationModel.ChangeColor(new Bitmap(_userButton.Image), Color.Black);
        }

        private void functionalButton_MouseMove(object sender, MouseEventArgs e)
        {
            _functionalButton.ForeColor = Color.CornflowerBlue;
            _functionalButton.Image = _presentationModel.ChangeColor(new Bitmap(_functionalButton.Image), Color.CornflowerBlue);
        }

        private void userButton_MouseMove(object sender, MouseEventArgs e)
        {
            _userButton.ForeColor = Color.CornflowerBlue;
            _userButton.Image = _presentationModel.ChangeColor(new Bitmap(_userButton.Image), Color.CornflowerBlue);
        }
    }
}
