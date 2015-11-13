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
        private MainForm mainForm;
        private ArrayList buttons;

        public UserInterfaceForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            buttons = new ArrayList();
            NoFocusCueButton projectsButton = GetItemButton();
            projectsButton.Text = "Projects";
            projectsButton.Image = Properties.Resources.ios7_folder_outline;
            projectsButton.Click += projectsButton_Click;
            flowLayoutPanel1.Controls.Add(projectsButton);
        }

        void projectsButton_Click(object sender, EventArgs e)
        {
            mainForm.AddFormToPanel(new ProjectListForm(mainForm));
            for (int i = 0; i < buttons.Count; i++)
            {
                InterfaceModel model = (InterfaceModel)buttons[i];
                flowLayoutPanel1.Controls.Remove(model.arrow);
                flowLayoutPanel1.Controls.Remove(model.button);
                buttons.Remove(model);
            }
        }

        public class InterfaceModel
        {
            public Form form;
            public PictureBox arrow;
            public Button button;
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
            bool isFinded = false;
            for (int i = 0; i < buttons.Count; i++)
            {
                InterfaceModel model = (InterfaceModel)buttons[i];
                if (isFinded)
                {
                    flowLayoutPanel1.Controls.Remove(model.arrow);
                    flowLayoutPanel1.Controls.Remove(model.button);
                    buttons.Remove(model);
                }
                else if (model.button == button)
                {
                    mainForm.AddFormToPanel(model.form);
                    isFinded = true;
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.ForeColor = Color.CornflowerBlue;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Black;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.ForeColor = Color.CornflowerBlue;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
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
