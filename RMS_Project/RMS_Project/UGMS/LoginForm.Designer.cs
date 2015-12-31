namespace RMS_Project
{
    partial class LoginForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.registerButton = new System.Windows.Forms.Button();
            this.signInButton = new System.Windows.Forms.Button();
            this.email = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rememberCheckBox = new System.Windows.Forms.CheckBox();
            this.emailLinkLabel = new System.Windows.Forms.LinkLabel();
            this.forgetPasswordLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.registerButton, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.signInButton, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.email, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.password, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.rememberCheckBox, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.emailLinkLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.forgetPasswordLinkLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(50);
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 561);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // registerButton
            // 
            this.registerButton.AccessibleName = "createAccountButton";
            this.registerButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registerButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.Location = new System.Drawing.Point(395, 474);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(165, 34);
            this.registerButton.TabIndex = 6;
            this.registerButton.Text = "Create account";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // signInButton
            // 
            this.signInButton.AccessibleName = "signInButton";
            this.signInButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signInButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInButton.Location = new System.Drawing.Point(566, 474);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(165, 34);
            this.signInButton.TabIndex = 7;
            this.signInButton.Text = "Sign in";
            this.signInButton.UseVisualStyleBackColor = true;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // email
            // 
            this.email.AccessibleName = "emailLabel";
            this.tableLayoutPanel1.SetColumnSpan(this.email, 2);
            this.email.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::RMS_Project.Properties.Settings.Default, "Email", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.email.Dock = System.Windows.Forms.DockStyle.Fill;
            this.email.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.email.Location = new System.Drawing.Point(53, 158);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(336, 26);
            this.email.TabIndex = 1;
            this.email.Text = global::RMS_Project.Properties.Settings.Default.Email;
            // 
            // password
            // 
            this.password.AccessibleName = "passwordLabel";
            this.tableLayoutPanel1.SetColumnSpan(this.password, 2);
            this.password.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::RMS_Project.Properties.Settings.Default, "Password", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.password.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.password.Location = new System.Drawing.Point(395, 158);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(336, 26);
            this.password.TabIndex = 2;
            this.password.Text = global::RMS_Project.Properties.Settings.Default.Password;
            this.password.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(395, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rememberCheckBox
            // 
            this.rememberCheckBox.AutoSize = true;
            this.rememberCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rememberCheckBox.Checked = global::RMS_Project.Properties.Settings.Default.RememberMe;
            this.tableLayoutPanel1.SetColumnSpan(this.rememberCheckBox, 2);
            this.rememberCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::RMS_Project.Properties.Settings.Default, "RememberMe", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.rememberCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rememberCheckBox.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rememberCheckBox.Location = new System.Drawing.Point(395, 449);
            this.rememberCheckBox.Name = "rememberCheckBox";
            this.rememberCheckBox.Size = new System.Drawing.Size(336, 19);
            this.rememberCheckBox.TabIndex = 5;
            this.rememberCheckBox.Text = "Remember me";
            this.rememberCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rememberCheckBox.UseVisualStyleBackColor = true;
            // 
            // emailLinkLabel
            // 
            this.emailLinkLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.emailLinkLabel, 4);
            this.emailLinkLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emailLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.emailLinkLabel.LinkColor = System.Drawing.Color.LightCoral;
            this.emailLinkLabel.Location = new System.Drawing.Point(53, 220);
            this.emailLinkLabel.Name = "emailLinkLabel";
            this.emailLinkLabel.Size = new System.Drawing.Size(678, 226);
            this.emailLinkLabel.TabIndex = 4;
            this.emailLinkLabel.TabStop = true;
            this.emailLinkLabel.Text = "Can\'t find your confirmation email?";
            this.emailLinkLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // forgetPasswordLinkLabel
            // 
            this.forgetPasswordLinkLabel.ActiveLinkColor = System.Drawing.Color.Salmon;
            this.forgetPasswordLinkLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.forgetPasswordLinkLabel, 4);
            this.forgetPasswordLinkLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.forgetPasswordLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.forgetPasswordLinkLabel.LinkColor = System.Drawing.Color.LightCoral;
            this.forgetPasswordLinkLabel.Location = new System.Drawing.Point(53, 195);
            this.forgetPasswordLinkLabel.Name = "forgetPasswordLinkLabel";
            this.forgetPasswordLinkLabel.Size = new System.Drawing.Size(678, 25);
            this.forgetPasswordLinkLabel.TabIndex = 3;
            this.forgetPasswordLinkLabel.TabStop = true;
            this.forgetPasswordLinkLabel.Text = "Forgot your password?";
            this.forgetPasswordLinkLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label3, 4);
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(678, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "If you don\'t have an account, please create one to access services and resources." +
    "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label4, 4);
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(678, 50);
            this.label4.TabIndex = 14;
            this.label4.Text = "Sign into your Account";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LoginForm
            // 
            this.AccessibleName = "loginForm";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.CheckBox rememberCheckBox;
        private System.Windows.Forms.LinkLabel emailLinkLabel;
        private System.Windows.Forms.LinkLabel forgetPasswordLinkLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

