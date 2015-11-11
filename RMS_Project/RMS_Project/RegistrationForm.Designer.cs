namespace RMS_Project
{
    partial class RegistrantionForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.registerTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.registerTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // registerTableLayoutPanel
            // 
            this.registerTableLayoutPanel.ColumnCount = 3;
            this.registerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.registerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.registerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.registerTableLayoutPanel.Controls.Add(this.userNameLabel, 0, 2);
            this.registerTableLayoutPanel.Controls.Add(this.passwordLabel, 0, 1);
            this.registerTableLayoutPanel.Controls.Add(this.emailLabel, 0, 0);
            this.registerTableLayoutPanel.Controls.Add(this.email, 1, 0);
            this.registerTableLayoutPanel.Controls.Add(this.userName, 1, 2);
            this.registerTableLayoutPanel.Controls.Add(this.password, 1, 1);
            this.registerTableLayoutPanel.Controls.Add(this.confirmButton, 1, 3);
            this.registerTableLayoutPanel.Controls.Add(this.backButton, 2, 3);
            this.registerTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registerTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.registerTableLayoutPanel.Name = "registerTableLayoutPanel";
            this.registerTableLayoutPanel.RowCount = 4;
            this.registerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.registerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.registerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.registerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.registerTableLayoutPanel.Size = new System.Drawing.Size(453, 364);
            this.registerTableLayoutPanel.TabIndex = 0;
            this.registerTableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // userNameLabel
            // 
            this.userNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(3, 221);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(74, 12);
            this.userNameLabel.TabIndex = 7;
            this.userNameLabel.Text = "User Name：";
            this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(3, 130);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(74, 12);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "Password：";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(3, 39);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(74, 12);
            this.emailLabel.TabIndex = 0;
            this.emailLabel.Text = "E-mail：";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.emailLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // email
            // 
            this.email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.registerTableLayoutPanel.SetColumnSpan(this.email, 2);
            this.email.Location = new System.Drawing.Point(83, 34);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(367, 22);
            this.email.TabIndex = 1;
            // 
            // userName
            // 
            this.userName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.registerTableLayoutPanel.SetColumnSpan(this.userName, 2);
            this.userName.Location = new System.Drawing.Point(83, 216);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(367, 22);
            this.userName.TabIndex = 3;
            // 
            // password
            // 
            this.password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.registerTableLayoutPanel.SetColumnSpan(this.password, 2);
            this.password.Location = new System.Drawing.Point(83, 125);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(367, 22);
            this.password.TabIndex = 2;
            // 
            // confirmButton
            // 
            this.confirmButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.confirmButton.Location = new System.Drawing.Point(295, 307);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 4;
            this.confirmButton.Text = "confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.comfirmButton);
            // 
            // backButton
            // 
            this.backButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.backButton.Location = new System.Drawing.Point(376, 307);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(74, 23);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "back";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // RegistrantionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 364);
            this.Controls.Add(this.registerTableLayoutPanel);
            this.Name = "RegistrantionForm";
            this.Text = "RegistrantionForm";
            this.registerTableLayoutPanel.ResumeLayout(false);
            this.registerTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel registerTableLayoutPanel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button backButton;
    }
}

