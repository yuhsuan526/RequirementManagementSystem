using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace RMS_Project
{
    public partial class LoginForm : Form
    {
        private MainForm mainForm;

        public LoginForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private async void PostProduct()
        {
            JObject jObject = new JObject();
            jObject["email"] = email.Text;
            jObject["password"] = password.Text;

            string status = await mainForm._model.SignIn(jObject);
            if (status == "success")
            {
                if (rememberCheckBox.Checked)
                {
                    Properties.Settings.Default.Email = email.Text;
                    Properties.Settings.Default.Password = password.Text;
                    Properties.Settings.Default.RememberMe = true;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.Email = "";
                    Properties.Settings.Default.Password = "";
                    Properties.Settings.Default.RememberMe = false;
                    Properties.Settings.Default.Save();
                }
                mainForm.SignIn();

            }
            else if (status == "帳號或密碼錯誤")
            {
                MessageBox.Show("帳號或密碼錯誤", "Error", MessageBoxButtons.OK);
            }
            else if (status == "登入失敗")
            {
                MessageBox.Show("登入失敗", "Error", MessageBoxButtons.OK);
            }
            else if (status == "伺服器無回應")
            {
                MessageBox.Show("伺服器無回應", "Error", MessageBoxButtons.OK);
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            mainForm.AddFormToPanel(new RegistrantionForm(mainForm));
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            PostProduct();
        }

    }
}
