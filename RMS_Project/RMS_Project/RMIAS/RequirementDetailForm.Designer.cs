namespace RMS_Project
{
    partial class RequirementDetailForm
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._nameLabel = new System.Windows.Forms.Label();
            this._descriptionTextBox = new System.Windows.Forms.TextBox();
            this._memoTextBox = new System.Windows.Forms.TextBox();
            this._commentDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._commentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 280F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this._nameLabel, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this._descriptionTextBox, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this._memoTextBox, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this._commentDataGridView, 3, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(819, 521);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::RMS_Project.Properties.Resources.requirement_icon;
            this.pictureBox1.Location = new System.Drawing.Point(83, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.tableLayoutPanel2.SetRowSpan(this.pictureBox1, 5);
            this.pictureBox1.Size = new System.Drawing.Size(274, 256);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // _nameLabel
            // 
            this._nameLabel.AutoSize = true;
            this._nameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._nameLabel.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(153)))));
            this._nameLabel.Location = new System.Drawing.Point(363, 40);
            this._nameLabel.Name = "_nameLabel";
            this._nameLabel.Size = new System.Drawing.Size(209, 40);
            this._nameLabel.TabIndex = 1;
            this._nameLabel.Text = "label1";
            this._nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _descriptionTextBox
            // 
            this._descriptionTextBox.BackColor = System.Drawing.SystemColors.Control;
            this._descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._descriptionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._descriptionTextBox.Location = new System.Drawing.Point(363, 83);
            this._descriptionTextBox.Multiline = true;
            this._descriptionTextBox.Name = "_descriptionTextBox";
            this._descriptionTextBox.Size = new System.Drawing.Size(209, 194);
            this._descriptionTextBox.TabIndex = 4;
            // 
            // _memoTextBox
            // 
            this._memoTextBox.BackColor = System.Drawing.SystemColors.Control;
            this._memoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._memoTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._memoTextBox.Location = new System.Drawing.Point(363, 283);
            this._memoTextBox.Multiline = true;
            this._memoTextBox.Name = "_memoTextBox";
            this._memoTextBox.Size = new System.Drawing.Size(209, 194);
            this._memoTextBox.TabIndex = 5;
            // 
            // _commentDataGridView
            // 
            this._commentDataGridView.AccessibleName = "projectDataGridView";
            this._commentDataGridView.AllowUserToAddRows = false;
            this._commentDataGridView.AllowUserToDeleteRows = false;
            this._commentDataGridView.AllowUserToResizeColumns = false;
            this._commentDataGridView.AllowUserToResizeRows = false;
            this._commentDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this._commentDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._commentDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._commentDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._commentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._commentDataGridView.ColumnHeadersVisible = false;
            this._commentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3});
            this._commentDataGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._commentDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this._commentDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._commentDataGridView.Location = new System.Drawing.Point(575, 80);
            this._commentDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this._commentDataGridView.MultiSelect = false;
            this._commentDataGridView.Name = "_commentDataGridView";
            this._commentDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._commentDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this._commentDataGridView.RowHeadersVisible = false;
            this._commentDataGridView.RowHeadersWidth = 50;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._commentDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tableLayoutPanel2.SetRowSpan(this._commentDataGridView, 2);
            this._commentDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;
            this._commentDataGridView.RowTemplate.DividerHeight = 1;
            this._commentDataGridView.RowTemplate.Height = 50;
            this._commentDataGridView.RowTemplate.ReadOnly = true;
            this._commentDataGridView.Size = new System.Drawing.Size(161, 400);
            this._commentDataGridView.TabIndex = 6;
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
            this.Column3.Image = global::RMS_Project.Properties.Resources.ios7_close_empty;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column3.Width = 5;
            // 
            // RequirementDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 521);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "RequirementDetailForm";
            this.Text = "RequirementDetailForm";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._commentDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label _nameLabel;
        private System.Windows.Forms.TextBox _descriptionTextBox;
        private System.Windows.Forms.TextBox _memoTextBox;
        private System.Windows.Forms.DataGridView _commentDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Column3;


    }
}