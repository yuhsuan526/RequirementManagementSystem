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
    public partial class ProjectEditorForm : Form
    {
        private MainForm mainForm;

        public ProjectEditorForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }
    }
}
