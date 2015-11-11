namespace RMS_Project
{
    partial class MainForm
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
            this.mainFormPanel = new System.Windows.Forms.Panel();
            this.mainFormLoginButton = new System.Windows.Forms.Button();
            this.mainFormRegisterButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.mainFormPanel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.mainFormLoginButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.mainFormRegisterButton, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 261);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // mainFormPanel
            // 
            this.mainFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainFormPanel.Location = new System.Drawing.Point(3, 55);
            this.mainFormPanel.Name = "mainFormPanel";
            this.mainFormPanel.Size = new System.Drawing.Size(221, 203);
            this.mainFormPanel.TabIndex = 0;
            // 
            // mainFormLoginButton
            // 
            this.mainFormLoginButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainFormLoginButton.Location = new System.Drawing.Point(230, 3);
            this.mainFormLoginButton.Name = "mainFormLoginButton";
            this.mainFormLoginButton.Size = new System.Drawing.Size(51, 20);
            this.mainFormLoginButton.TabIndex = 1;
            this.mainFormLoginButton.Text = "Login";
            this.mainFormLoginButton.UseVisualStyleBackColor = true;
            this.mainFormLoginButton.Click += new System.EventHandler(this.mainFormLoginButton_Click);
            // 
            // mainFormRegisterButton
            // 
            this.mainFormRegisterButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainFormRegisterButton.Location = new System.Drawing.Point(230, 29);
            this.mainFormRegisterButton.Name = "mainFormRegisterButton";
            this.mainFormRegisterButton.Size = new System.Drawing.Size(51, 20);
            this.mainFormRegisterButton.TabIndex = 2;
            this.mainFormRegisterButton.Text = "Register";
            this.mainFormRegisterButton.UseVisualStyleBackColor = true;
            this.mainFormRegisterButton.Click += new System.EventHandler(this.mainFormRegisterButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel mainFormPanel;
        private System.Windows.Forms.Button mainFormLoginButton;
        private System.Windows.Forms.Button mainFormRegisterButton;

    }
}