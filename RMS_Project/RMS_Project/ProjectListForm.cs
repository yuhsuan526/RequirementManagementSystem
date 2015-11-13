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
            this.ProjectListDataGridView.Rows.Add("Design Pattern", "1:2:3");
            this.ProjectListDataGridView.ClearSelection();
        }

        private void ProjectListDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = ProjectListDataGridView.Rows[e.RowIndex].Cells[0];
            Form form = new RequirementListForm();
            mainForm.AddFormToPanel(form);
            mainForm.AddFormButtonToUserInterface(form, cell.Value.ToString(), Properties.Resources.ios7_paper_outline);
        }
    }
}
