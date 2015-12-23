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
    public partial class TraceabilityMatrixForm : Form
    {
        public TraceabilityMatrixForm()
        {
            InitializeComponent();
            DataGridViewColumnCollection columns = matrixDataGridView.Columns;
            columns.Add("nullColumn", "Traceability Matrix");
            columns.Add("testColumn1", "Test 1");
            columns.Add("testColumn2", "Test 2");
            columns.Add("testColumn3", "Test 3");
            columns.Add("testColumn4", "Test 4");
            columns.Add("testColumn5", "Test 5");
            columns.Add("testColumn6", "Test 6");
            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.Name = "testColumn7";
            checkColumn.HeaderText = "Test 7";
            checkColumn.TrueValue = true;
            checkColumn.FalseValue = false;
            checkColumn.ReadOnly = true;
            checkColumn.FillWeight = 10; //if the datagridview is resized (on form resize) the checkbox won't take up too much; value is relative to the other columns' fill values
            matrixDataGridView.Columns.Add(checkColumn);

            columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);

            DataGridViewRowCollection rows = matrixDataGridView.Rows;
            rows.Add("Requirement 1");
            rows.Add("Requirement 2");
            rows.Add("Requirement 3");
            rows.Add("Requirement 4");
            rows.Add("Requirement 5");
            rows.Add("Requirement 6");
            rows.Add("Requirement 7");
            rows.Add("Requirement 8");
            rows.Add("Requirement 9");
            rows.Add("Requirement 10");
            rows.Add("Requirement 11");
            rows.Add("Requirement 12");
            matrixDataGridView.Columns[0].Frozen = true;
            foreach (DataGridViewRow row in matrixDataGridView.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[7];
                chk.Value = chk.TrueValue;
            }
        }
    }
}
