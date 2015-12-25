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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this._yourProjectListDataGridView = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this._managedProjectListDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this._joinedProjectListDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._yourProjectListDataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._managedProjectListDataGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._joinedProjectListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _yourProjectListDataGridView
            // 
            this._yourProjectListDataGridView.AccessibleName = "projectDataGridView";
            this._yourProjectListDataGridView.AllowUserToAddRows = false;
            this._yourProjectListDataGridView.AllowUserToDeleteRows = false;
            this._yourProjectListDataGridView.AllowUserToResizeColumns = false;
            this._yourProjectListDataGridView.AllowUserToResizeRows = false;
            this._yourProjectListDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this._yourProjectListDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._yourProjectListDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this._yourProjectListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._yourProjectListDataGridView.ColumnHeadersVisible = false;
            this._yourProjectListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3});
            this._yourProjectListDataGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._yourProjectListDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this._yourProjectListDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._yourProjectListDataGridView.Location = new System.Drawing.Point(0, 0);
            this._yourProjectListDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this._yourProjectListDataGridView.MultiSelect = false;
            this._yourProjectListDataGridView.Name = "_yourProjectListDataGridView";
            this._yourProjectListDataGridView.ReadOnly = true;
            this._yourProjectListDataGridView.RowHeadersVisible = false;
            this._yourProjectListDataGridView.RowHeadersWidth = 50;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._yourProjectListDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this._yourProjectListDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;
            this._yourProjectListDataGridView.RowTemplate.DividerHeight = 1;
            this._yourProjectListDataGridView.RowTemplate.Height = 50;
            this._yourProjectListDataGridView.RowTemplate.ReadOnly = true;
            this._yourProjectListDataGridView.Size = new System.Drawing.Size(476, 422);
            this._yourProjectListDataGridView.TabIndex = 1;
            this._yourProjectListDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._yourProjectListDataGridView_CellContentClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(50, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(484, 461);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this._yourProjectListDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 35);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(476, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Your Projects";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this._managedProjectListDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 35);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(476, 422);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Managed Projects";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // _managedProjectListDataGridView
            // 
            this._managedProjectListDataGridView.AccessibleName = "";
            this._managedProjectListDataGridView.AllowUserToAddRows = false;
            this._managedProjectListDataGridView.AllowUserToDeleteRows = false;
            this._managedProjectListDataGridView.AllowUserToResizeColumns = false;
            this._managedProjectListDataGridView.AllowUserToResizeRows = false;
            this._managedProjectListDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this._managedProjectListDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._managedProjectListDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this._managedProjectListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._managedProjectListDataGridView.ColumnHeadersVisible = false;
            this._managedProjectListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this._managedProjectListDataGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._managedProjectListDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this._managedProjectListDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._managedProjectListDataGridView.Location = new System.Drawing.Point(3, 3);
            this._managedProjectListDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this._managedProjectListDataGridView.MultiSelect = false;
            this._managedProjectListDataGridView.Name = "_managedProjectListDataGridView";
            this._managedProjectListDataGridView.ReadOnly = true;
            this._managedProjectListDataGridView.RowHeadersVisible = false;
            this._managedProjectListDataGridView.RowHeadersWidth = 50;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._managedProjectListDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this._managedProjectListDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;
            this._managedProjectListDataGridView.RowTemplate.DividerHeight = 1;
            this._managedProjectListDataGridView.RowTemplate.Height = 50;
            this._managedProjectListDataGridView.RowTemplate.ReadOnly = true;
            this._managedProjectListDataGridView.Size = new System.Drawing.Size(470, 416);
            this._managedProjectListDataGridView.TabIndex = 2;
            this._managedProjectListDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._managedProjectListDataGridView_CellContentClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this._joinedProjectListDataGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 35);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(476, 422);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Joined Projects";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // _joinedProjectListDataGridView
            // 
            this._joinedProjectListDataGridView.AccessibleName = "";
            this._joinedProjectListDataGridView.AllowUserToAddRows = false;
            this._joinedProjectListDataGridView.AllowUserToDeleteRows = false;
            this._joinedProjectListDataGridView.AllowUserToResizeColumns = false;
            this._joinedProjectListDataGridView.AllowUserToResizeRows = false;
            this._joinedProjectListDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this._joinedProjectListDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._joinedProjectListDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this._joinedProjectListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._joinedProjectListDataGridView.ColumnHeadersVisible = false;
            this._joinedProjectListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3});
            this._joinedProjectListDataGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._joinedProjectListDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this._joinedProjectListDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._joinedProjectListDataGridView.Location = new System.Drawing.Point(0, 0);
            this._joinedProjectListDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this._joinedProjectListDataGridView.MultiSelect = false;
            this._joinedProjectListDataGridView.Name = "_joinedProjectListDataGridView";
            this._joinedProjectListDataGridView.ReadOnly = true;
            this._joinedProjectListDataGridView.RowHeadersVisible = false;
            this._joinedProjectListDataGridView.RowHeadersWidth = 50;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._joinedProjectListDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this._joinedProjectListDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;
            this._joinedProjectListDataGridView.RowTemplate.DividerHeight = 1;
            this._joinedProjectListDataGridView.RowTemplate.Height = 50;
            this._joinedProjectListDataGridView.RowTemplate.ReadOnly = true;
            this._joinedProjectListDataGridView.Size = new System.Drawing.Size(476, 422);
            this._joinedProjectListDataGridView.TabIndex = 2;
            this._joinedProjectListDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._joinedProjectListDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.FillWeight = 179.6954F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column3.HeaderText = "Column3";
            this.Column3.Image = global::RMS_Project.Properties.Resources.ios7_trash;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column3.Width = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.FillWeight = 179.6954F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ProjectListForm
            // 
            this.AccessibleName = "projectListForm";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.tabControl1);
            this.Name = "ProjectListForm";
            this.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.Text = "ProjectListForm";
            ((System.ComponentModel.ISupportInitialize)(this._yourProjectListDataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._managedProjectListDataGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._joinedProjectListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView _yourProjectListDataGridView;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView _managedProjectListDataGridView;
        private System.Windows.Forms.DataGridView _joinedProjectListDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}