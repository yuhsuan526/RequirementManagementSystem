namespace RMS_Project
{
    partial class RequirementEditorForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.handlerComboBox = new System.Windows.Forms.ComboBox();
            this.priorityComboBox = new System.Windows.Forms.ComboBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DescriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.MemoRichTextBox = new System.Windows.Forms.RichTextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.versionLabel = new System.Windows.Forms.Label();
            this.handlerTitleLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.handlerComboBox, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.priorityComboBox, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.statusComboBox, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.nameTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.DescriptionRichTextBox, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.MemoRichTextBox, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.confirmButton, 4, 8);
            this.tableLayoutPanel1.Controls.Add(this.typeComboBox, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.versionLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.handlerTitleLabel, 4, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(67, 25, 67, 25);
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(803, 554);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // handlerComboBox
            // 
            this.handlerComboBox.AccessibleName = "statusComboBox";
            this.handlerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.handlerComboBox.FormattingEnabled = true;
            this.handlerComboBox.Location = new System.Drawing.Point(603, 125);
            this.handlerComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.handlerComboBox.Name = "handlerComboBox";
            this.handlerComboBox.Size = new System.Drawing.Size(125, 23);
            this.handlerComboBox.TabIndex = 25;
            this.handlerComboBox.SelectedIndexChanged += new System.EventHandler(this.handlerComboBox_SelectedIndexChanged);
            // 
            // priorityComboBox
            // 
            this.priorityComboBox.AccessibleName = "priorityComboBox";
            this.priorityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.priorityComboBox.FormattingEnabled = true;
            this.priorityComboBox.Location = new System.Drawing.Point(337, 125);
            this.priorityComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.priorityComboBox.Name = "priorityComboBox";
            this.priorityComboBox.Size = new System.Drawing.Size(125, 23);
            this.priorityComboBox.TabIndex = 22;
            this.priorityComboBox.SelectedIndexChanged += new System.EventHandler(this.priorityComboBox_SelectedIndexChanged);
            // 
            // statusComboBox
            // 
            this.statusComboBox.AccessibleName = "statusComboBox";
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(470, 125);
            this.statusComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(125, 23);
            this.statusComboBox.TabIndex = 21;
            this.statusComboBox.SelectedIndexChanged += new System.EventHandler(this.statusComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(71, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Type";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 5);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(71, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(661, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameTextBox
            // 
            this.nameTextBox.AccessibleName = "requirementName";
            this.tableLayoutPanel1.SetColumnSpan(this.nameTextBox, 5);
            this.nameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameTextBox.Location = new System.Drawing.Point(71, 61);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(661, 25);
            this.nameTextBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(204, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "Version";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(337, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 32);
            this.label3.TabIndex = 11;
            this.label3.Text = "Priority";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(470, 89);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 32);
            this.label6.TabIndex = 12;
            this.label6.Text = "Status";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label4, 5);
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(71, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(661, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Description";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label7, 5);
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(71, 316);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(661, 32);
            this.label7.TabIndex = 13;
            this.label7.Text = "Memo";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DescriptionRichTextBox
            // 
            this.DescriptionRichTextBox.AccessibleName = "descriptionLabel";
            this.tableLayoutPanel1.SetColumnSpan(this.DescriptionRichTextBox, 5);
            this.DescriptionRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DescriptionRichTextBox.Location = new System.Drawing.Point(71, 189);
            this.DescriptionRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DescriptionRichTextBox.Name = "DescriptionRichTextBox";
            this.DescriptionRichTextBox.Size = new System.Drawing.Size(661, 123);
            this.DescriptionRichTextBox.TabIndex = 19;
            this.DescriptionRichTextBox.Text = "";
            // 
            // MemoRichTextBox
            // 
            this.MemoRichTextBox.AccessibleName = "memoLabel";
            this.tableLayoutPanel1.SetColumnSpan(this.MemoRichTextBox, 5);
            this.MemoRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MemoRichTextBox.Location = new System.Drawing.Point(71, 352);
            this.MemoRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.MemoRichTextBox.Name = "MemoRichTextBox";
            this.MemoRichTextBox.Size = new System.Drawing.Size(661, 123);
            this.MemoRichTextBox.TabIndex = 18;
            this.MemoRichTextBox.Text = "";
            // 
            // confirmButton
            // 
            this.confirmButton.AccessibleName = "confirmButton";
            this.confirmButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.confirmButton.Location = new System.Drawing.Point(603, 483);
            this.confirmButton.Margin = new System.Windows.Forms.Padding(4);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(129, 42);
            this.confirmButton.TabIndex = 5;
            this.confirmButton.Text = "confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirm_Click);
            // 
            // typeComboBox
            // 
            this.typeComboBox.AccessibleName = "typeComboBox";
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(71, 125);
            this.typeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(125, 23);
            this.typeComboBox.TabIndex = 20;
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.versionLabel.Location = new System.Drawing.Point(203, 121);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(127, 32);
            this.versionLabel.TabIndex = 23;
            // 
            // handlerTitleLabel
            // 
            this.handlerTitleLabel.AutoSize = true;
            this.handlerTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.handlerTitleLabel.Location = new System.Drawing.Point(602, 89);
            this.handlerTitleLabel.Name = "handlerTitleLabel";
            this.handlerTitleLabel.Size = new System.Drawing.Size(131, 32);
            this.handlerTitleLabel.TabIndex = 24;
            this.handlerTitleLabel.Text = "Handler";
            this.handlerTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RequirementEditorForm
            // 
            this.AccessibleName = "requirementEditorForm";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 554);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RequirementEditorForm";
            this.Text = "RequirementEditorForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox DescriptionRichTextBox;
        private System.Windows.Forms.RichTextBox MemoRichTextBox;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.ComboBox priorityComboBox;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.ComboBox handlerComboBox;
        private System.Windows.Forms.Label handlerTitleLabel;
    }
}