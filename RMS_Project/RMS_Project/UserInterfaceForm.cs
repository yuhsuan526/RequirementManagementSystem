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
    public partial class UserInterfaceForm : Form
    {
        private MainForm mainForm;

        public UserInterfaceForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
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
}
