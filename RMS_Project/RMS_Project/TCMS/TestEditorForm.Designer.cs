namespace RMS_Project
{
    partial class TestEditorForm
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
            this.testEditorTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.expectedResultTextBox = new System.Windows.Forms.TextBox();
            this.ownerComboBox = new System.Windows.Forms.ComboBox();
            this.inputDataLabel = new System.Windows.Forms.Label();
            this.testNameLabel = new System.Windows.Forms.Label();
            this.testNameTextBox = new System.Windows.Forms.TextBox();
            this.expectedResultLabel = new System.Windows.Forms.Label();
            this.inputDataTextBox = new System.Windows.Forms.TextBox();
            this.ownerLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.testEditorTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // testEditorTableLayoutPanel
            // 
            this.testEditorTableLayoutPanel.ColumnCount = 4;
            this.testEditorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.testEditorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.testEditorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.testEditorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.testEditorTableLayoutPanel.Controls.Add(this.descriptionRichTextBox, 0, 5);
            this.testEditorTableLayoutPanel.Controls.Add(this.expectedResultTextBox, 1, 2);
            this.testEditorTableLayoutPanel.Controls.Add(this.ownerComboBox, 1, 3);
            this.testEditorTableLayoutPanel.Controls.Add(this.inputDataLabel, 0, 1);
            this.testEditorTableLayoutPanel.Controls.Add(this.testNameLabel, 0, 0);
            this.testEditorTableLayoutPanel.Controls.Add(this.testNameTextBox, 1, 0);
            this.testEditorTableLayoutPanel.Controls.Add(this.expectedResultLabel, 0, 2);
            this.testEditorTableLayoutPanel.Controls.Add(this.inputDataTextBox, 1, 1);
            this.testEditorTableLayoutPanel.Controls.Add(this.ownerLabel, 0, 3);
            this.testEditorTableLayoutPanel.Controls.Add(this.label4, 0, 4);
            this.testEditorTableLayoutPanel.Controls.Add(this.confirmButton, 3, 6);
            this.testEditorTableLayoutPanel.Controls.Add(this.checkedListBox, 3, 1);
            this.testEditorTableLayoutPanel.Controls.Add(this.label3, 3, 0);
            this.testEditorTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testEditorTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.testEditorTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.testEditorTableLayoutPanel.Name = "testEditorTableLayoutPanel";
            this.testEditorTableLayoutPanel.Padding = new System.Windows.Forms.Padding(67, 25, 67, 25);
            this.testEditorTableLayoutPanel.RowCount = 7;
            this.testEditorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.testEditorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.testEditorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.testEditorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.testEditorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.testEditorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.testEditorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.testEditorTableLayoutPanel.Size = new System.Drawing.Size(799, 585);
            this.testEditorTableLayoutPanel.TabIndex = 2;
            // 
            // descriptionRichTextBox
            // 
            this.testEditorTableLayoutPanel.SetColumnSpan(this.descriptionRichTextBox, 4);
            this.descriptionRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionRichTextBox.Location = new System.Drawing.Point(53, 154);
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            this.descriptionRichTextBox.Size = new System.Drawing.Size(493, 251);
            this.descriptionRichTextBox.TabIndex = 25;
            this.descriptionRichTextBox.Text = "";
            // 
            // expectedResultTextBox
            // 
            this.testEditorTableLayoutPanel.SetColumnSpan(this.expectedResultTextBox, 2);
            this.expectedResultTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expectedResultTextBox.Location = new System.Drawing.Point(153, 75);
            this.expectedResultTextBox.Name = "expectedResultTextBox";
            this.expectedResultTextBox.Size = new System.Drawing.Size(243, 22);
            this.expectedResultTextBox.TabIndex = 23;
            // 
            // ownerComboBox
            // 
            this.testEditorTableLayoutPanel.SetColumnSpan(this.ownerComboBox, 2);
            this.ownerComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ownerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ownerComboBox.FormattingEnabled = true;
            this.ownerComboBox.Location = new System.Drawing.Point(153, 101);
            this.ownerComboBox.Name = "ownerComboBox";
            this.ownerComboBox.Size = new System.Drawing.Size(243, 20);
            this.ownerComboBox.TabIndex = 21;
            this.ownerComboBox.SelectedIndexChanged += new System.EventHandler(this.ownerComboBox_SelectedIndexChanged);
            // 
            // inputDataLabel
            // 
            this.inputDataLabel.AutoSize = true;
            this.inputDataLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputDataLabel.Location = new System.Drawing.Point(53, 46);
            this.inputDataLabel.Name = "inputDataLabel";
            this.inputDataLabel.Size = new System.Drawing.Size(94, 26);
            this.inputDataLabel.TabIndex = 6;
            this.inputDataLabel.Text = "InputData";
            this.inputDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // testNameLabel
            // 
            this.testNameLabel.AutoSize = true;
            this.testNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testNameLabel.Location = new System.Drawing.Point(71, 25);
            this.testNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.testNameLabel.Name = "testNameLabel";
            this.testNameLabel.Size = new System.Drawing.Size(94, 26);
            this.testNameLabel.TabIndex = 0;
            this.testNameLabel.Text = "Name";
            this.testNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // testNameTextBox
            // 
            this.testEditorTableLayoutPanel.SetColumnSpan(this.testNameTextBox, 2);
            this.testNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testNameTextBox.Location = new System.Drawing.Point(153, 23);
            this.testNameTextBox.Name = "testNameTextBox";
            this.testNameTextBox.Size = new System.Drawing.Size(243, 22);
            this.testNameTextBox.TabIndex = 1;
            // 
            // expectedResultLabel
            // 
            this.expectedResultLabel.AutoSize = true;
            this.expectedResultLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expectedResultLabel.Location = new System.Drawing.Point(53, 72);
            this.expectedResultLabel.Name = "expectedResultLabel";
            this.expectedResultLabel.Size = new System.Drawing.Size(94, 26);
            this.expectedResultLabel.TabIndex = 10;
            this.expectedResultLabel.Text = "Expected Result";
            this.expectedResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // inputDataTextBox
            // 
            this.testEditorTableLayoutPanel.SetColumnSpan(this.inputDataTextBox, 2);
            this.inputDataTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputDataTextBox.Location = new System.Drawing.Point(153, 49);
            this.inputDataTextBox.Name = "inputDataTextBox";
            this.inputDataTextBox.Size = new System.Drawing.Size(243, 22);
            this.inputDataTextBox.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(402, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "Associated Requirements";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ownerLabel
            // 
            this.ownerLabel.AutoSize = true;
            this.ownerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ownerLabel.Location = new System.Drawing.Point(53, 98);
            this.ownerLabel.Name = "ownerLabel";
            this.ownerLabel.Size = new System.Drawing.Size(94, 27);
            this.ownerLabel.TabIndex = 12;
            this.ownerLabel.Text = "Owner";
            this.ownerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.testEditorTableLayoutPanel.SetColumnSpan(this.label4, 4);
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(53, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(657, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Description";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // confirmButton
            // 
            this.confirmButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.confirmButton.Location = new System.Drawing.Point(402, 411);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(144, 34);
            this.confirmButton.TabIndex = 5;
            this.confirmButton.Text = "confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirm_Click);
            // 
            // checkedListBox
            // 
            this.checkedListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Location = new System.Drawing.Point(402, 49);
            this.checkedListBox.Name = "checkedListBox";
            this.testEditorTableLayoutPanel.SetRowSpan(this.checkedListBox, 3);
            this.checkedListBox.Size = new System.Drawing.Size(144, 73);
            this.checkedListBox.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(536, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 32);
            this.label3.TabIndex = 11;
            this.label3.Text = "Associated Requirements";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TestEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 585);
            this.Controls.Add(this.testEditorTableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TestEditorForm";
            this.Text = "TestEditorForm";
            this.testEditorTableLayoutPanel.ResumeLayout(false);
            this.testEditorTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel testEditorTableLayoutPanel;
        private System.Windows.Forms.ComboBox ownerComboBox;
        private System.Windows.Forms.Label inputDataLabel;
        private System.Windows.Forms.Label testNameLabel;
        private System.Windows.Forms.TextBox testNameTextBox;
        private System.Windows.Forms.TextBox inputDataTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ownerLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.TextBox expectedResultTextBox;
        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
        private System.Windows.Forms.Label expectedResultLabel;
        private System.Windows.Forms.CheckedListBox checkedListBox;
    }
}