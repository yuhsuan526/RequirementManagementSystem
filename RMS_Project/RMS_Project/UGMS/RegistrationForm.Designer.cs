﻿namespace RMS_Project
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
            this.identityLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.identityComboBox = new System.Windows.Forms.ComboBox();
            this.registerTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // registerTableLayoutPanel
            // 
            this.registerTableLayoutPanel.ColumnCount = 2;
            this.registerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.registerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.registerTableLayoutPanel.Controls.Add(this.identityLabel, 0, 3);
            this.registerTableLayoutPanel.Controls.Add(this.label1, 0, 0);
            this.registerTableLayoutPanel.Controls.Add(this.createButton, 0, 12);
            this.registerTableLayoutPanel.Controls.Add(this.backButton, 1, 12);
            this.registerTableLayoutPanel.Controls.Add(this.userNameLabel, 0, 1);
            this.registerTableLayoutPanel.Controls.Add(this.emailLabel, 0, 5);
            this.registerTableLayoutPanel.Controls.Add(this.passwordLabel, 0, 7);
            this.registerTableLayoutPanel.Controls.Add(this.userName, 0, 2);
            this.registerTableLayoutPanel.Controls.Add(this.email, 0, 6);
            this.registerTableLayoutPanel.Controls.Add(this.password, 0, 8);
            this.registerTableLayoutPanel.Controls.Add(this.confirmPasswordLabel, 0, 9);
            this.registerTableLayoutPanel.Controls.Add(this.confirmPasswordTextBox, 0, 10);
            this.registerTableLayoutPanel.Controls.Add(this.identityComboBox, 0, 4);
            this.registerTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registerTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.registerTableLayoutPanel.Name = "registerTableLayoutPanel";
            this.registerTableLayoutPanel.Padding = new System.Windows.Forms.Padding(50);
            this.registerTableLayoutPanel.RowCount = 13;
            this.registerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.registerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.registerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.registerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.registerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.registerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.registerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.registerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.registerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.registerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.registerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.registerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.registerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.registerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.registerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.registerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.registerTableLayoutPanel.Size = new System.Drawing.Size(623, 420);
            this.registerTableLayoutPanel.TabIndex = 0;
            // 
            // identityLabel
            // 
            this.identityLabel.AutoSize = true;
            this.registerTableLayoutPanel.SetColumnSpan(this.identityLabel, 2);
            this.identityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.identityLabel.Location = new System.Drawing.Point(53, 135);
            this.identityLabel.Name = "identityLabel";
            this.identityLabel.Size = new System.Drawing.Size(517, 25);
            this.identityLabel.TabIndex = 9;
            this.identityLabel.Text = "Identity";
            this.identityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.registerTableLayoutPanel.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(53, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(517, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Create a Account";
            // 
            // createButton
            // 
            this.createButton.AccessibleName = "createAccountButton";
            this.createButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.createButton.Location = new System.Drawing.Point(370, 363);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(120, 23);
            this.createButton.TabIndex = 5;
            this.createButton.Text = "Create account";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // backButton
            // 
            this.backButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.backButton.Location = new System.Drawing.Point(496, 363);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(74, 23);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // userNameLabel
            // 
            this.userNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(53, 91);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(437, 12);
            this.userNameLabel.TabIndex = 7;
            this.userNameLabel.Text = "User Name";
            this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(53, 191);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(437, 12);
            this.emailLabel.TabIndex = 0;
            this.emailLabel.Text = "Email";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(53, 241);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(437, 12);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "Password";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // userName
            // 
            this.userName.AccessibleName = "userNameLabel";
            this.userName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.registerTableLayoutPanel.SetColumnSpan(this.userName, 2);
            this.userName.Location = new System.Drawing.Point(53, 113);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(517, 22);
            this.userName.TabIndex = 1;
            // 
            // email
            // 
            this.email.AccessibleName = "emailLabel";
            this.email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.registerTableLayoutPanel.SetColumnSpan(this.email, 2);
            this.email.Location = new System.Drawing.Point(53, 213);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(517, 22);
            this.email.TabIndex = 2;
            // 
            // password
            // 
            this.password.AccessibleName = "passwordLabel";
            this.password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.registerTableLayoutPanel.SetColumnSpan(this.password, 2);
            this.password.Location = new System.Drawing.Point(53, 263);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(517, 22);
            this.password.TabIndex = 3;
            this.password.UseSystemPasswordChar = true;
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.registerTableLayoutPanel.SetColumnSpan(this.confirmPasswordLabel, 2);
            this.confirmPasswordLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.confirmPasswordLabel.Location = new System.Drawing.Point(53, 285);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(517, 25);
            this.confirmPasswordLabel.TabIndex = 8;
            this.confirmPasswordLabel.Text = "Confirm password";
            this.confirmPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.AccessibleName = "confirmPasswordLabel";
            this.registerTableLayoutPanel.SetColumnSpan(this.confirmPasswordTextBox, 2);
            this.confirmPasswordTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(53, 313);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(517, 22);
            this.confirmPasswordTextBox.TabIndex = 4;
            this.confirmPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // identityComboBox
            // 
            this.registerTableLayoutPanel.SetColumnSpan(this.identityComboBox, 2);
            this.identityComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.identityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.identityComboBox.FormattingEnabled = true;
            this.identityComboBox.Location = new System.Drawing.Point(53, 163);
            this.identityComboBox.Name = "identityComboBox";
            this.identityComboBox.Size = new System.Drawing.Size(517, 20);
            this.identityComboBox.TabIndex = 10;
            // 
            // RegistrantionForm
            // 
            this.AccessibleName = "registrantionForm";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 420);
            this.Controls.Add(this.registerTableLayoutPanel);
            this.Name = "RegistrantionForm";
            this.Text = "RegistrantionForm";
            this.registerTableLayoutPanel.ResumeLayout(false);
            this.registerTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel registerTableLayoutPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.TextBox confirmPasswordTextBox;
        private System.Windows.Forms.Label identityLabel;
        private System.Windows.Forms.ComboBox identityComboBox;
    }
}
