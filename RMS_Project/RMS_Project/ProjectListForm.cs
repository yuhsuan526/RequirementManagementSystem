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
    public partial class ProjectListForm : Form
    {
        private MainForm mainForm;

        public ProjectListForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.ProjectListDataGridView.Rows.Add("Requirement Management System", "5:2:0");
            this.ProjectListDataGridView.Rows.Add("Requirement Management System", "5:2:0");
            this.ProjectListDataGridView.ClearSelection();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
