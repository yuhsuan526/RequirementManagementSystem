namespace RMS_Project
{
    partial class UserListForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.memberDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this._priorityComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Controls.Add(this.memberDataGridView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.userTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this._priorityComboBox, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(50, 20, 50, 20);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(647, 446);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // memberDataGridView
            // 
            this.memberDataGridView.AccessibleName = "memberDataGridView";
            this.memberDataGridView.AllowUserToAddRows = false;
            this.memberDataGridView.AllowUserToDeleteRows = false;
            this.memberDataGridView.AllowUserToResizeColumns = false;
            this.memberDataGridView.AllowUserToResizeRows = false;
            this.memberDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.memberDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.memberDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.memberDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.memberDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.memberDataGridView.ColumnHeadersVisible = false;
            this.memberDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.tableLayoutPanel1.SetColumnSpan(this.memberDataGridView, 4);
            this.memberDataGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.memberDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.memberDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memberDataGridView.Location = new System.Drawing.Point(53, 23);
            this.memberDataGridView.MultiSelect = false;
            this.memberDataGridView.Name = "memberDataGridView";
            this.memberDataGridView.ReadOnly = true;
            this.memberDataGridView.RowHeadersVisible = false;
            this.memberDataGridView.RowHeadersWidth = 50;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.memberDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;
            this.memberDataGridView.RowTemplate.DividerHeight = 1;
            this.memberDataGridView.RowTemplate.Height = 50;
            this.memberDataGridView.RowTemplate.ReadOnly = true;
            this.memberDataGridView.Size = new System.Drawing.Size(541, 370);
            this.memberDataGridView.TabIndex = 3;
            this.memberDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._userListDataGridView_CellContentClick);
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
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column3.HeaderText = "Column3";
            this.Column3.Image = global::RMS_Project.Properties.Resources.ios7_close_empty;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column3.Width = 5;
            // 
            // userTextBox
            // 
            this.userTextBox.AccessibleName = "userName";
            this.userTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.userTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTextBox.Location = new System.Drawing.Point(153, 399);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(271, 26);
            this.userTextBox.TabIndex = 2;
            // 
            // _priorityComboBox
            // 
            this._priorityComboBox.AccessibleName = "priorityComboBox";
            this._priorityComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._priorityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._priorityComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._priorityComboBox.FormattingEnabled = true;
            this._priorityComboBox.Location = new System.Drawing.Point(500, 399);
            this._priorityComboBox.Name = "_priorityComboBox";
            this._priorityComboBox.Size = new System.Drawing.Size(94, 27);
            this._priorityComboBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "New User";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(430, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Priority";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserListForm
            // 
            this.AccessibleName = "UserListForm";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 446);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UserListForm";
            this.Text = "userListForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.DataGridView memberDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewImageColumn Column3;
        private System.Windows.Forms.ComboBox _priorityComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}