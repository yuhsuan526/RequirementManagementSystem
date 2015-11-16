namespace RMS_Project
{
    partial class RequirementListForm
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
            this.requirementListDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.requirementListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // requirementListDataGridView
            // 
            this.requirementListDataGridView.AllowUserToAddRows = false;
            this.requirementListDataGridView.AllowUserToDeleteRows = false;
            this.requirementListDataGridView.AllowUserToResizeColumns = false;
            this.requirementListDataGridView.AllowUserToResizeRows = false;
            this.requirementListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.requirementListDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.requirementListDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.requirementListDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.requirementListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.requirementListDataGridView.ColumnHeadersVisible = false;
            this.requirementListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.requirementListDataGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.requirementListDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.requirementListDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.requirementListDataGridView.Location = new System.Drawing.Point(50, 0);
            this.requirementListDataGridView.MultiSelect = false;
            this.requirementListDataGridView.Name = "requirementListDataGridView";
            this.requirementListDataGridView.ReadOnly = true;
            this.requirementListDataGridView.RowHeadersVisible = false;
            this.requirementListDataGridView.RowHeadersWidth = 50;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requirementListDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.requirementListDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;
            this.requirementListDataGridView.RowTemplate.DividerHeight = 1;
            this.requirementListDataGridView.RowTemplate.Height = 50;
            this.requirementListDataGridView.RowTemplate.ReadOnly = true;
            this.requirementListDataGridView.Size = new System.Drawing.Size(419, 363);
            this.requirementListDataGridView.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.FillWeight = 179.6954F;
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column2.FillWeight = 20.30457F;
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Width = 5;
            // 
            // RequirementListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 363);
            this.Controls.Add(this.requirementListDataGridView);
            this.Name = "RequirementListForm";
            this.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.Text = "RequirementListForm";
            ((System.ComponentModel.ISupportInitialize)(this.requirementListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView requirementListDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;


    }
}