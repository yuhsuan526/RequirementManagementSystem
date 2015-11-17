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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.requirementDesLabel = new System.Windows.Forms.Label();
            this.requirementNameLabel = new System.Windows.Forms.Label();
            this.requirementNumLabel = new System.Windows.Forms.Label();
            this.requirementMemoLabel = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.memoLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.requirementDesLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.requirementNameLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.requirementNumLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.requirementMemoLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.numberLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.nameLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.descriptionLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.memoLabel, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(50, 20, 50, 20);
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 261);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // requirementDesLabel
            // 
            this.requirementDesLabel.AutoSize = true;
            this.requirementDesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.requirementDesLabel.Location = new System.Drawing.Point(53, 70);
            this.requirementDesLabel.Name = "requirementDesLabel";
            this.requirementDesLabel.Size = new System.Drawing.Size(124, 25);
            this.requirementDesLabel.TabIndex = 6;
            this.requirementDesLabel.Text = "Description：";
            this.requirementDesLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // requirementNameLabel
            // 
            this.requirementNameLabel.AutoSize = true;
            this.requirementNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.requirementNameLabel.Location = new System.Drawing.Point(53, 45);
            this.requirementNameLabel.Name = "requirementNameLabel";
            this.requirementNameLabel.Size = new System.Drawing.Size(124, 25);
            this.requirementNameLabel.TabIndex = 0;
            this.requirementNameLabel.Text = "Project Name：";
            this.requirementNameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // requirementNumLabel
            // 
            this.requirementNumLabel.AutoSize = true;
            this.requirementNumLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.requirementNumLabel.Location = new System.Drawing.Point(53, 20);
            this.requirementNumLabel.Name = "requirementNumLabel";
            this.requirementNumLabel.Size = new System.Drawing.Size(124, 25);
            this.requirementNumLabel.TabIndex = 7;
            this.requirementNumLabel.Text = "Requirement Number：";
            this.requirementNumLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // requirementMemoLabel
            // 
            this.requirementMemoLabel.AutoSize = true;
            this.requirementMemoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.requirementMemoLabel.Location = new System.Drawing.Point(53, 95);
            this.requirementMemoLabel.Name = "requirementMemoLabel";
            this.requirementMemoLabel.Size = new System.Drawing.Size(124, 25);
            this.requirementMemoLabel.TabIndex = 5;
            this.requirementMemoLabel.Text = "Memo：";
            this.requirementMemoLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numberLabel
            // 
            this.numberLabel.AccessibleName = "projectNumber";
            this.numberLabel.AutoSize = true;
            this.numberLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberLabel.Location = new System.Drawing.Point(183, 20);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(48, 25);
            this.numberLabel.TabIndex = 8;
            // 
            // nameLabel
            // 
            this.nameLabel.AccessibleName = "projectName";
            this.nameLabel.AutoSize = true;
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameLabel.Location = new System.Drawing.Point(183, 45);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(48, 25);
            this.nameLabel.TabIndex = 9;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AccessibleName = "projectDescription";
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionLabel.Location = new System.Drawing.Point(183, 70);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(48, 25);
            this.descriptionLabel.TabIndex = 10;
            // 
            // memoLabel
            // 
            this.memoLabel.AccessibleName = "projectMemo";
            this.memoLabel.AutoSize = true;
            this.memoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoLabel.Location = new System.Drawing.Point(183, 95);
            this.memoLabel.Name = "memoLabel";
            this.memoLabel.Size = new System.Drawing.Size(48, 25);
            this.memoLabel.TabIndex = 11;
            // 
            // RequirementDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RequirementDetailForm";
            this.Text = "RequirementDetailForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label requirementDesLabel;
        private System.Windows.Forms.Label requirementNameLabel;
        private System.Windows.Forms.Label requirementNumLabel;
        private System.Windows.Forms.Label requirementMemoLabel;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label memoLabel;
    }
}