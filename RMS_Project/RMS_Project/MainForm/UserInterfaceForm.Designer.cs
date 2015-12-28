namespace RMS_Project
{
    partial class UserInterfaceForm
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
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this._userButton = new RMS_Project.NoFocusCueButton();
            this._functionalButton = new RMS_Project.NoFocusCueButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.Controls.Add(this._userButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this._functionalButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 81);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.AutoSize = true;
            this.flowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanel.Size = new System.Drawing.Size(544, 81);
            this.flowLayoutPanel.TabIndex = 5;
            this.flowLayoutPanel.WrapContents = false;
            // 
            // _userButton
            // 
            this._userButton.AccessibleName = "UserButton";
            this._userButton.AutoSize = true;
            this._userButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._userButton.FlatAppearance.BorderSize = 0;
            this._userButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._userButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._userButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._userButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._userButton.Image = global::RMS_Project.Properties.Resources.ios7_contact_outline;
            this._userButton.Location = new System.Drawing.Point(667, 3);
            this._userButton.Name = "_userButton";
            this._userButton.Size = new System.Drawing.Size(114, 75);
            this._userButton.TabIndex = 6;
            this._userButton.TabStop = false;
            this._userButton.Text = "User";
            this._userButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._userButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._userButton.UseVisualStyleBackColor = true;
            this._userButton.Click += new System.EventHandler(this.userButton_Click);
            this._userButton.MouseLeave += new System.EventHandler(this.userButton_MouseLeave);
            this._userButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.userButton_MouseMove);
            // 
            // _functionalButton
            // 
            this._functionalButton.AccessibleName = "NewProjectButton";
            this._functionalButton.AutoSize = true;
            this._functionalButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._functionalButton.FlatAppearance.BorderSize = 0;
            this._functionalButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._functionalButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._functionalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._functionalButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._functionalButton.Image = global::RMS_Project.Properties.Resources.ios7_plus_outline;
            this._functionalButton.Location = new System.Drawing.Point(547, 3);
            this._functionalButton.Name = "_functionalButton";
            this._functionalButton.Size = new System.Drawing.Size(114, 75);
            this._functionalButton.TabIndex = 0;
            this._functionalButton.TabStop = false;
            this._functionalButton.Text = "New";
            this._functionalButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._functionalButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._functionalButton.UseVisualStyleBackColor = true;
            this._functionalButton.Click += new System.EventHandler(this.functionalButton_Click);
            this._functionalButton.MouseLeave += new System.EventHandler(this.functionalButton_MouseLeave);
            this._functionalButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.functionalButton_MouseMove);
            // 
            // UserInterfaceForm
            // 
            this.AccessibleName = "UserInterfaceForm";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 81);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "UserInterfaceForm";
            this.Text = "UserInterfaceForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private NoFocusCueButton _functionalButton;
        private NoFocusCueButton _userButton;
    }
}