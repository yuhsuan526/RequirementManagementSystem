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
            this.projectTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.userListView = new System.Windows.Forms.ListView();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.addUserButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.projectTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableLayoutPanel1.Controls.Add(this.projectTabControl, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.mainPanel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 361);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // projectTabControl
            // 
            this.projectTabControl.Controls.Add(this.tabPage1);
            this.projectTabControl.Controls.Add(this.tabPage2);
            this.projectTabControl.Controls.Add(this.tabPage3);
            this.projectTabControl.Controls.Add(this.tabPage4);
            this.projectTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectTabControl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectTabControl.Location = new System.Drawing.Point(544, 0);
            this.projectTabControl.Margin = new System.Windows.Forms.Padding(0);
            this.projectTabControl.Name = "projectTabControl";
            this.projectTabControl.SelectedIndex = 0;
            this.projectTabControl.Size = new System.Drawing.Size(240, 361);
            this.projectTabControl.TabIndex = 0;
            this.projectTabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.projectTabControl_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            this.tabPage1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(232, 329);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "users";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Controls.Add(this.userListView, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.userTextBox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.addUserButton, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(226, 323);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // userListView
            // 
            this.userListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel2.SetColumnSpan(this.userListView, 2);
            this.userListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userListView.FullRowSelect = true;
            this.userListView.HideSelection = false;
            this.userListView.Location = new System.Drawing.Point(3, 3);
            this.userListView.Name = "userListView";
            this.userListView.Size = new System.Drawing.Size(220, 287);
            this.userListView.TabIndex = 0;
            this.userListView.TileSize = new System.Drawing.Size(188, 70);
            this.userListView.UseCompatibleStateImageBehavior = false;
            this.userListView.View = System.Windows.Forms.View.Tile;
            this.userListView.ClientSizeChanged += new System.EventHandler(this.userListView_ClientSizeChanged);
            // 
            // userTextBox
            // 
            this.userTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userTextBox.Location = new System.Drawing.Point(3, 296);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(190, 26);
            this.userTextBox.TabIndex = 1;
            // 
            // addUserButton
            // 
            this.addUserButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addUserButton.Location = new System.Drawing.Point(196, 293);
            this.addUserButton.Margin = new System.Windows.Forms.Padding(0);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(30, 30);
            this.addUserButton.TabIndex = 2;
            this.addUserButton.Text = "+";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(232, 329);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "requirements";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(232, 329);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tests";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(232, 329);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "others";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(3, 3);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(538, 355);
            this.mainPanel.TabIndex = 1;
            // 
            // ProjectMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ProjectMainForm";
            this.Text = "ProjectDetailForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.projectTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl projectTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.ListView userListView;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.Button addUserButton;
    }
}