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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._mainPanel = new System.Windows.Forms.Panel();
            this.menuFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.projectButton = new RMS_Project.NoFocusCueButton();
            this.memberButton = new RMS_Project.NoFocusCueButton();
            this.requirementButton = new RMS_Project.NoFocusCueButton();
            this.testButton = new RMS_Project.NoFocusCueButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this._mainPanel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.menuFlowLayoutPanel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 361);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // _mainPanel
            // 
            this._mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mainPanel.Location = new System.Drawing.Point(63, 3);
            this._mainPanel.Name = "_mainPanel";
            this._mainPanel.Size = new System.Drawing.Size(718, 355);
            this._mainPanel.TabIndex = 1;
            // 
            // menuFlowLayoutPanel
            // 
            this.menuFlowLayoutPanel.BackColor = System.Drawing.Color.White;
            this.menuFlowLayoutPanel.Controls.Add(this.projectButton);
            this.menuFlowLayoutPanel.Controls.Add(this.memberButton);
            this.menuFlowLayoutPanel.Controls.Add(this.requirementButton);
            this.menuFlowLayoutPanel.Controls.Add(this.testButton);
            this.menuFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.menuFlowLayoutPanel.Location = new System.Drawing.Point(0, 2);
            this.menuFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.menuFlowLayoutPanel.Name = "menuFlowLayoutPanel";
            this.menuFlowLayoutPanel.Size = new System.Drawing.Size(60, 359);
            this.menuFlowLayoutPanel.TabIndex = 2;
            // 
            // projectButton
            // 
            this.projectButton.AccessibleName = "projectButton";
            this.projectButton.BackColor = System.Drawing.Color.Transparent;
            this.projectButton.FlatAppearance.BorderSize = 0;
            this.projectButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.projectButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.projectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.projectButton.Image = global::RMS_Project.Properties.Resources.ios7_folder;
            this.projectButton.Location = new System.Drawing.Point(5, 3);
            this.projectButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.projectButton.Name = "projectButton";
            this.projectButton.Size = new System.Drawing.Size(50, 50);
            this.projectButton.TabIndex = 3;
            this.projectButton.UseVisualStyleBackColor = false;
            this.projectButton.Click += new System.EventHandler(this.projectButton_Click);
            this.projectButton.MouseLeave += new System.EventHandler(this.noFocusCueButton1_MouseLeave);
            this.projectButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.noFocusCueButton1_MouseMove);
            // 
            // memberButton
            // 
            this.memberButton.AccessibleName = "memberButton";
            this.memberButton.BackColor = System.Drawing.Color.Transparent;
            this.memberButton.FlatAppearance.BorderSize = 0;
            this.memberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.memberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.memberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memberButton.Image = global::RMS_Project.Properties.Resources.ios7_people;
            this.memberButton.Location = new System.Drawing.Point(5, 59);
            this.memberButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.memberButton.Name = "memberButton";
            this.memberButton.Size = new System.Drawing.Size(50, 50);
            this.memberButton.TabIndex = 0;
            this.memberButton.UseVisualStyleBackColor = false;
            this.memberButton.Click += new System.EventHandler(this.memberButton_Click);
            this.memberButton.MouseLeave += new System.EventHandler(this.noFocusCueButton1_MouseLeave);
            this.memberButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.noFocusCueButton1_MouseMove);
            // 
            // requirementButton
            // 
            this.requirementButton.AccessibleName = "requirementButton";
            this.requirementButton.BackColor = System.Drawing.Color.Transparent;
            this.requirementButton.FlatAppearance.BorderSize = 0;
            this.requirementButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.requirementButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.requirementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.requirementButton.Image = global::RMS_Project.Properties.Resources.ios7_paper;
            this.requirementButton.Location = new System.Drawing.Point(5, 115);
            this.requirementButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.requirementButton.Name = "requirementButton";
            this.requirementButton.Size = new System.Drawing.Size(50, 50);
            this.requirementButton.TabIndex = 1;
            this.requirementButton.UseVisualStyleBackColor = false;
            this.requirementButton.Click += new System.EventHandler(this.requirementButton_Click);
            this.requirementButton.MouseLeave += new System.EventHandler(this.noFocusCueButton1_MouseLeave);
            this.requirementButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.noFocusCueButton1_MouseMove);
            // 
            // testButton
            // 
            this.testButton.AccessibleName = "testButton";
            this.testButton.BackColor = System.Drawing.Color.Transparent;
            this.testButton.FlatAppearance.BorderSize = 0;
            this.testButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.testButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.testButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testButton.Image = global::RMS_Project.Properties.Resources.ios7_browsers;
            this.testButton.Location = new System.Drawing.Point(5, 171);
            this.testButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(50, 50);
            this.testButton.TabIndex = 2;
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
            this.menuFlowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel _mainPanel;
        private System.Windows.Forms.FlowLayoutPanel menuFlowLayoutPanel;
        private NoFocusCueButton memberButton;
        private NoFocusCueButton requirementButton;
        private NoFocusCueButton testButton;
        private NoFocusCueButton projectButton;
    }
}