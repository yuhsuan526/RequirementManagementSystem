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
        private MainForm _mainForm;
        private ArrayList buttons;
        private ContextMenuStrip contextMenuStrip;
        ProjectListForm projectListForm;
        public enum FeatureType { New, Edit, Hide };
        public UserInterfaceForm(MainForm mainForm)
        {
            InitializeComponent();
            this._mainForm = mainForm;
            buttons = new ArrayList();
            NoFocusCueButton projectsButton = GetItemButton();
            projectsButton.Text = "Projects";
            projectsButton.Margin = new Padding(10, 13, 0, 2);
            projectsButton.Image = Properties.Resources.ios7_briefcase_outline;
            projectsButton.Click += projectsButton_Click;
            flowLayoutPanel1.Controls.Add(projectsButton);
            contextMenuStrip = new ContextMenuStrip();
            contextMenuStrip.Items.Add("Edit account");
            contextMenuStrip.Items.Add("Manage organizations");
            contextMenuStrip.Items.Add("Help");
            contextMenuStrip.Items.Add("Sign out");
            contextMenuStrip.ShowImageMargin = false;
            contextMenuStrip.ItemClicked += contextMenuStrip_ItemClicked;
            projectListForm = new ProjectListForm(mainForm);
            mainForm.AddFormToPanel(projectListForm);
        }

        void contextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Sign out")
            {
                contextMenuStrip.Hide();
                _mainForm.SignOut();
            }
        }

        void projectsButton_Click(object sender, EventArgs e)
        {
            if (_mainForm.PopFormsFromPanel(projectListForm))
            {
                for (int i = 0; i < buttons.Count; i++)
                {
                    InterfaceModel model = (InterfaceModel)buttons[i];
                    flowLayoutPanel1.Controls.Remove(model.arrow);
                    flowLayoutPanel1.Controls.Remove(model.button);
                }
                buttons.Clear();
            }
        }

        public class InterfaceModel
        {
            public Form form;
            public PictureBox arrow;
            public Button button;
        }

        public void SetFeatureButton(FeatureType type)
        {
            switch(type)
            {
                case FeatureType.New:
                    newButton.Text = "New";
                    newButton.Image = Properties.Resources.ios7_plus_outline;
                    newButton.Visible = true;
                    break;
                case FeatureType.Edit:
                    newButton.Text = "Edit";
                    newButton.Image = Properties.Resources.edit;
                    newButton.Visible = true;
                    break;
                case FeatureType.Hide:
                    newButton.Visible = false;
                    break;
            }
        }

        public void AddFormButtonToBar(Form form, string buttonName, Image image)
        {
            InterfaceModel model = new InterfaceModel();
            model.form = form;
            model.arrow = new PictureBox();
            model.arrow.Image = Properties.Resources.ios7_arrow_forward_small;
            model.arrow.SizeMode = PictureBoxSizeMode.AutoSize;
            model.arrow.Margin = new Padding(0, 30, 0, 0);
            model.button = GetItemButton();
            model.button.Image = image;
            model.button.Text = buttonName;
            model.button.Click += button_Click;
            flowLayoutPanel1.Controls.Add(model.arrow);
            flowLayoutPanel1.Controls.Add(model.button);
            buttons.Add(model);
        }

        void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            bool isAvailable = false;
            int i;
            for (i = 0; i < buttons.Count; i++)
            {
                InterfaceModel model = (InterfaceModel)buttons[i];
                if (model.button == button)
                {
                    isAvailable = _mainForm.PopFormsFromPanel(model.form);
                    break;
                }
            }
            if (isAvailable)
            {
                for (i = i + 1; i < buttons.Count; i++)
                {
                    InterfaceModel model = (InterfaceModel)buttons[i];
                    flowLayoutPanel1.Controls.Remove(model.arrow);
                    flowLayoutPanel1.Controls.Remove(model.button);
                    buttons.Remove(model);
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

        private void newButton_Click(object sender, EventArgs e)
        {
            if (buttons.Count <= 0)
            {
                Control control = _mainForm.GetCurrentFormInPancel();
                if (!control.GetType().Equals(typeof(ProjectEditorForm)))
                {
                    _mainForm.AddFormToPanel(new ProjectEditorForm(_mainForm));
                }
            }
            else
            {
                Control control = _mainForm.GetCurrentFormInPancel();
                if (control.GetType().Equals(typeof(ProjectMainForm)))
                {
                    ProjectMainForm form = control as ProjectMainForm;
                    form.ClickNewButton();
                }
            }
        }

        private void newButton_MouseLeave(object sender, EventArgs e)
        {
            newButton.ForeColor = Color.Black;
            newButton.Image = MainForm.ChangeColor(new Bitmap(newButton.Image), Color.Black);
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            contextMenuStrip.Show(userButton, new Point(userButton.Width / 2, (int)(userButton.Height * 0.7f)));
        }


        private void userButton_MouseLeave(object sender, EventArgs e)
        {
            userButton.ForeColor = Color.Black;
            userButton.Image = MainForm.ChangeColor(new Bitmap(userButton.Image), Color.Black);
        }

        private void newButton_MouseMove(object sender, MouseEventArgs e)
        {
            newButton.ForeColor = Color.CornflowerBlue;
            newButton.Image = MainForm.ChangeColor(new Bitmap(newButton.Image), Color.CornflowerBlue);
        }

        private void userButton_MouseMove(object sender, MouseEventArgs e)
        {
            userButton.ForeColor = Color.CornflowerBlue;
            userButton.Image = MainForm.ChangeColor(new Bitmap(userButton.Image), Color.CornflowerBlue);
        }
    }

    public class NoFocusCueButton : Button
    {
        public override void NotifyDefault(bool value)
        {
            base.NotifyDefault(false);
        }
    }
}
