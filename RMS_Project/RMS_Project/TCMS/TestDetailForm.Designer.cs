namespace RMS_Project
{
    partial class TestDetailForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this._requirementListDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inputDataLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.expectedResultLabel = new System.Windows.Forms.Label();
            this.ownerLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.handlerLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._requirementListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Description";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "Input data";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "Expected results";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 26);
            this.label7.TabIndex = 13;
            this.label7.Text = "Owner";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._requirementListDataGridView, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.inputDataLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.idLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.nameLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.expectedResultLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.ownerLabel, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.descriptionTextBox, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.handlerLabel, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tableLayoutPanel1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(50, 15);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(684, 531);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 26);
            this.label6.TabIndex = 34;
            this.label6.Text = "ID";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _requirementListDataGridView
            // 
            this._requirementListDataGridView.AccessibleName = "testDataGridView";
            this._requirementListDataGridView.AllowUserToAddRows = false;
            this._requirementListDataGridView.AllowUserToDeleteRows = false;
            this._requirementListDataGridView.AllowUserToResizeColumns = false;
            this._requirementListDataGridView.AllowUserToResizeRows = false;
            this._requirementListDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this._requirementListDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._requirementListDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this._requirementListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._requirementListDataGridView.ColumnHeadersVisible = false;
            this._requirementListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this._requirementListDataGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._requirementListDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this._requirementListDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._requirementListDataGridView.Location = new System.Drawing.Point(513, 26);
            this._requirementListDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this._requirementListDataGridView.MultiSelect = false;
            this._requirementListDataGridView.Name = "_requirementListDataGridView";
            this._requirementListDataGridView.ReadOnly = true;
            this._requirementListDataGridView.RowHeadersVisible = false;
            this._requirementListDataGridView.RowHeadersWidth = 50;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._requirementListDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.tableLayoutPanel1.SetRowSpan(this._requirementListDataGridView, 7);
            this._requirementListDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;
            this._requirementListDataGridView.RowTemplate.DividerHeight = 1;
            this._requirementListDataGridView.RowTemplate.Height = 50;
            this._requirementListDataGridView.RowTemplate.ReadOnly = true;
            this._requirementListDataGridView.Size = new System.Drawing.Size(171, 505);
            this._requirementListDataGridView.TabIndex = 31;
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
            // inputDataLabel
            // 
            this.inputDataLabel.AccessibleName = "inputDataLabel";
            this.inputDataLabel.AutoSize = true;
            this.inputDataLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputDataLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputDataLabel.Location = new System.Drawing.Point(118, 55);
            this.inputDataLabel.Margin = new System.Windows.Forms.Padding(3);
            this.inputDataLabel.Name = "inputDataLabel";
            this.inputDataLabel.Size = new System.Drawing.Size(392, 20);
            this.inputDataLabel.TabIndex = 23;
            this.inputDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // idLabel
            // 
            this.idLabel.AccessibleName = "idLabel";
            this.idLabel.AutoSize = true;
            this.idLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.idLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(118, 3);
            this.idLabel.Margin = new System.Windows.Forms.Padding(3);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(392, 20);
            this.idLabel.TabIndex = 20;
            this.idLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameLabel
            // 
            this.nameLabel.AccessibleName = "nameLabel";
            this.nameLabel.AutoSize = true;
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(118, 29);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(3);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(392, 20);
            this.nameLabel.TabIndex = 21;
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // expectedResultLabel
            // 
            this.expectedResultLabel.AccessibleName = "expectedResultLabel";
            this.expectedResultLabel.AutoSize = true;
            this.expectedResultLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expectedResultLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expectedResultLabel.Location = new System.Drawing.Point(118, 81);
            this.expectedResultLabel.Margin = new System.Windows.Forms.Padding(3);
            this.expectedResultLabel.Name = "expectedResultLabel";
            this.expectedResultLabel.Size = new System.Drawing.Size(392, 20);
            this.expectedResultLabel.TabIndex = 24;
            this.expectedResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ownerLabel
            // 
            this.ownerLabel.AccessibleName = "ownerLabel";
            this.ownerLabel.AutoSize = true;
            this.ownerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ownerLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ownerLabel.Location = new System.Drawing.Point(118, 107);
            this.ownerLabel.Margin = new System.Windows.Forms.Padding(3);
            this.ownerLabel.Name = "ownerLabel";
            this.ownerLabel.Size = new System.Drawing.Size(392, 20);
            this.ownerLabel.TabIndex = 26;
            this.ownerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(516, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 26);
            this.label1.TabIndex = 32;
            this.label1.Text = "Associated requirements";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(118, 185);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(392, 343);
            this.descriptionTextBox.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(2, 130);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 26);
            this.label8.TabIndex = 35;
            this.label8.Text = "Handler";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // handlerLabel
            // 
            this.handlerLabel.AccessibleName = "handlerLabel";
            this.handlerLabel.AutoSize = true;
            this.handlerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.handlerLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.handlerLabel.Location = new System.Drawing.Point(117, 130);
            this.handlerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.handlerLabel.Name = "handlerLabel";
            this.handlerLabel.Size = new System.Drawing.Size(394, 26);
            this.handlerLabel.TabIndex = 36;
            this.handlerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TestDetailForm
            // 
            this.AccessibleName = "testDetailForm";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TestDetailForm";
            this.Padding = new System.Windows.Forms.Padding(50, 15, 50, 15);
            this.Text = "TestDetailForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._requirementListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label inputDataLabel;
        private System.Windows.Forms.Label expectedResultLabel;
        private System.Windows.Forms.Label ownerLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView _requirementListDataGridView;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label handlerLabel;
    }
}