namespace RMS_Project
{
    partial class ProjectListForm
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
            this.ProjectListDataGridView = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ProjectListDataGridView
            // 
            this.ProjectListDataGridView.AllowUserToAddRows = false;
            this.ProjectListDataGridView.AllowUserToDeleteRows = false;
            this.ProjectListDataGridView.AllowUserToResizeColumns = false;
            this.ProjectListDataGridView.AllowUserToResizeRows = false;
            this.ProjectListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProjectListDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ProjectListDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProjectListDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ProjectListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProjectListDataGridView.ColumnHeadersVisible = false;
            this.ProjectListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.ProjectListDataGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProjectListDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.ProjectListDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjectListDataGridView.Location = new System.Drawing.Point(50, 0);
            this.ProjectListDataGridView.MultiSelect = false;
            this.ProjectListDataGridView.Name = "ProjectListDataGridView";
            this.ProjectListDataGridView.ReadOnly = true;
            this.ProjectListDataGridView.RowHeadersVisible = false;
            this.ProjectListDataGridView.RowHeadersWidth = 50;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectListDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.ProjectListDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;
            this.ProjectListDataGridView.RowTemplate.DividerHeight = 1;
            this.ProjectListDataGridView.RowTemplate.Height = 50;
            this.ProjectListDataGridView.RowTemplate.ReadOnly = true;
            this.ProjectListDataGridView.Size = new System.Drawing.Size(468, 440);
            this.ProjectListDataGridView.TabIndex = 1;
            this.ProjectListDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProjectListDataGridView_CellClick);
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
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // ProjectListForm
            // 
            this.AccessibleName = "projectListForm";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 440);
            this.Controls.Add(this.ProjectListDataGridView);
            this.Name = "ProjectListForm";
            this.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.Text = "ProjectListForm";
            ((System.ComponentModel.ISupportInitialize)(this.ProjectListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ProjectListDataGridView;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}