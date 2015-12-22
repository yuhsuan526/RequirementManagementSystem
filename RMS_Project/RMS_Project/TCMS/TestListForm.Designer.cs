namespace RMS_Project
{
    partial class TestListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.testListDataGridView = new System.Windows.Forms.DataGridView();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.testListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // testListDataGridView
            // 
            this.testListDataGridView.AccessibleName = "requirementListDataGridView";
            this.testListDataGridView.AllowUserToAddRows = false;
            this.testListDataGridView.AllowUserToDeleteRows = false;
            this.testListDataGridView.AllowUserToResizeColumns = false;
            this.testListDataGridView.AllowUserToResizeRows = false;
            this.testListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.testListDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.testListDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.testListDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.testListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testListDataGridView.ColumnHeadersVisible = false;
            this.testListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameColumn,
            this.idColumn});
            this.testListDataGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.testListDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.testListDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testListDataGridView.Location = new System.Drawing.Point(50, 0);
            this.testListDataGridView.MultiSelect = false;
            this.testListDataGridView.Name = "testListDataGridView";
            this.testListDataGridView.ReadOnly = true;
            this.testListDataGridView.RowHeadersVisible = false;
            this.testListDataGridView.RowHeadersWidth = 50;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testListDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.testListDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;
            this.testListDataGridView.RowTemplate.DividerHeight = 1;
            this.testListDataGridView.RowTemplate.Height = 50;
            this.testListDataGridView.RowTemplate.ReadOnly = true;
            this.testListDataGridView.Size = new System.Drawing.Size(476, 521);
            this.testListDataGridView.TabIndex = 3;
            // 
            // Column1
            // 
            this.nameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameColumn.FillWeight = 179.6954F;
            this.nameColumn.HeaderText = "Column1";
            this.nameColumn.Name = "Column1";
            this.nameColumn.ReadOnly = true;
            this.nameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column2
            // 
            this.idColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.idColumn.FillWeight = 20.30457F;
            this.idColumn.HeaderText = "Column2";
            this.idColumn.Name = "Column2";
            this.idColumn.ReadOnly = true;
            this.idColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idColumn.Width = 5;
            // 
            // TestListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 521);
            this.Controls.Add(this.testListDataGridView);
            this.Name = "TestListForm";
            this.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.Text = "TestListForm";
            ((System.ComponentModel.ISupportInitialize)(this.testListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView testListDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;

    }
}