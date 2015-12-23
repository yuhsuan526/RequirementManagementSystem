namespace RMS_Project
{
    partial class ProjectMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectMainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.projectButton = new RMS_Project.NoFocusCueButton();
            this._mainPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._nameLabel = new System.Windows.Forms.Label();
            this._descriptionText = new System.Windows.Forms.RichTextBox();
            this.memberButton = new RMS_Project.NoFocusCueButton();
            this.requirementButton = new RMS_Project.NoFocusCueButton();
            this.testButton = new RMS_Project.NoFocusCueButton();
            this.tableLayoutPanel1.SuspendLayout();
            this._mainPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.projectButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this._mainPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.memberButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.requirementButton, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.testButton, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 361);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // projectButton
            // 
            this.projectButton.AccessibleName = "projectButton";
            this.projectButton.BackColor = System.Drawing.Color.Transparent;
            this.projectButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectButton.FlatAppearance.BorderSize = 0;
            this.projectButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.projectButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.projectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.projectButton.Image = global::RMS_Project.Properties.Resources.ios7_folder;
            this.projectButton.Location = new System.Drawing.Point(5, 304);
            this.projectButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.projectButton.Name = "projectButton";
            this.projectButton.Size = new System.Drawing.Size(186, 54);
            this.projectButton.TabIndex = 3;
            this.projectButton.Text = " 0 / 0";
            this.projectButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.projectButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.projectButton.UseVisualStyleBackColor = false;
            this.projectButton.Click += new System.EventHandler(this.projectButton_Click);
            this.projectButton.MouseLeave += new System.EventHandler(this.noFocusCueButton1_MouseLeave);
            this.projectButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.noFocusCueButton1_MouseMove);
            // 
            // _mainPanel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this._mainPanel, 4);
            this._mainPanel.Controls.Add(this.tableLayoutPanel2);
            this._mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mainPanel.Location = new System.Drawing.Point(0, 0);
            this._mainPanel.Margin = new System.Windows.Forms.Padding(0);
            this._mainPanel.Name = "_mainPanel";
            this._mainPanel.Size = new System.Drawing.Size(784, 301);
            this._mainPanel.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 280F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this._nameLabel, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this._descriptionText, 2, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(784, 301);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(78, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.tableLayoutPanel2.SetRowSpan(this.pictureBox1, 4);
            this.pictureBox1.Size = new System.Drawing.Size(274, 256);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // _nameLabel
            // 
            this._nameLabel.AccessibleName = "projectName";
            this._nameLabel.AutoSize = true;
            this._nameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._nameLabel.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(153)))));
            this._nameLabel.Location = new System.Drawing.Point(358, 40);
            this._nameLabel.Name = "_nameLabel";
            this._nameLabel.Size = new System.Drawing.Size(346, 40);
            this._nameLabel.TabIndex = 1;
            this._nameLabel.Text = "label1";
            this._nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _descriptionText
            // 
            this._descriptionText.AccessibleName = "projectDescription";
            this._descriptionText.BackColor = System.Drawing.SystemColors.Control;
            this._descriptionText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._descriptionText.Dock = System.Windows.Forms.DockStyle.Fill;
            this._descriptionText.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._descriptionText.ForeColor = System.Drawing.Color.Black;
            this._descriptionText.Location = new System.Drawing.Point(358, 83);
            this._descriptionText.Name = "_descriptionText";
            this._descriptionText.ReadOnly = true;
            this._descriptionText.Size = new System.Drawing.Size(346, 175);
            this._descriptionText.TabIndex = 2;
            this._descriptionText.Text = "123";
            // 
            // memberButton
            // 
            this.memberButton.AccessibleName = "memberButton";
            this.memberButton.BackColor = System.Drawing.Color.Transparent;
            this.memberButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memberButton.FlatAppearance.BorderSize = 0;
            this.memberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.memberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.memberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memberButton.Image = global::RMS_Project.Properties.Resources.ios7_people;
            this.memberButton.Location = new System.Drawing.Point(201, 304);
            this.memberButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.memberButton.Name = "memberButton";
            this.memberButton.Size = new System.Drawing.Size(186, 54);
            this.memberButton.TabIndex = 0;
            this.memberButton.Text = " 0 / 0";
            this.memberButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.memberButton.UseVisualStyleBackColor = false;
            this.memberButton.Click += new System.EventHandler(this.memberButton_Click);
            this.memberButton.MouseLeave += new System.EventHandler(this.noFocusCueButton1_MouseLeave);
            this.memberButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.noFocusCueButton1_MouseMove);
            // 
            // requirementButton
            // 
            this.requirementButton.AccessibleName = "requirementButton";
            this.requirementButton.BackColor = System.Drawing.Color.Transparent;
            this.requirementButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.requirementButton.FlatAppearance.BorderSize = 0;
            this.requirementButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.requirementButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.requirementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.requirementButton.Image = global::RMS_Project.Properties.Resources.ios7_paper;
            this.requirementButton.Location = new System.Drawing.Point(397, 304);
            this.requirementButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.requirementButton.Name = "requirementButton";
            this.requirementButton.Size = new System.Drawing.Size(186, 54);
            this.requirementButton.TabIndex = 1;
            this.requirementButton.Text = " 0 / 0";
            this.requirementButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.requirementButton.UseVisualStyleBackColor = false;
            this.requirementButton.Click += new System.EventHandler(this.requirementButton_Click);
            this.requirementButton.MouseLeave += new System.EventHandler(this.noFocusCueButton1_MouseLeave);
            this.requirementButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.noFocusCueButton1_MouseMove);
            // 
            // testButton
            // 
            this.testButton.AccessibleName = "testButton";
            this.testButton.BackColor = System.Drawing.Color.Transparent;
            this.testButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testButton.FlatAppearance.BorderSize = 0;
            this.testButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.testButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.testButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testButton.Image = global::RMS_Project.Properties.Resources.ios7_browsers;
            this.testButton.Location = new System.Drawing.Point(593, 304);
            this.testButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(186, 54);
            this.testButton.TabIndex = 2;
            this.testButton.Text = " 0 / 0";
            this.testButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.testButton.UseVisualStyleBackColor = false;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            this.testButton.MouseLeave += new System.EventHandler(this.noFocusCueButton1_MouseLeave);
            this.testButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.noFocusCueButton1_MouseMove);
            // 
            // ProjectMainForm
            // 
            this.AccessibleName = "ProjectMainForm";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ProjectMainForm";
            this.Text = "ProjectMainForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this._mainPanel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private NoFocusCueButton memberButton;
        private NoFocusCueButton requirementButton;
        private NoFocusCueButton testButton;
        private NoFocusCueButton projectButton;
        private System.Windows.Forms.Panel _mainPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label _nameLabel;
        private System.Windows.Forms.RichTextBox _descriptionText;
    }
}