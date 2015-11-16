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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void PostProduct()
        {
            JObject jObject = new JObject();
            jObject["email"] = email.Text;
            jObject["password"] = password.Text;

            HttpClient client = new HttpClient();

            HttpResponseMessage response;
            Console.WriteLine(jObject.ToString());
            var httpClient = new HttpClient();
            try
            {
                response = await httpClient.PostAsync("http://140.124.183.32:3000/user/login", new StringContent(jObject.ToString(), Encoding.UTF8, "application/json"));
                string content = await response.Content.ReadAsStringAsync();
                Console.WriteLine(content);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Console.WriteLine(content);
                    JObject json = JObject.Parse(content);
                    string message = json["result"].ToString();
                    if (message == "success")
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
                        int uid = Int32.Parse(json["uid"].ToString());
                        string username = json["name"].ToString();
                        mainForm.SignIn(uid, username);
                    }
                    else
                    {
                        MessageBox.Show("帳號或密碼錯誤", "Error", MessageBoxButtons.OK);
                    }
                } 
                else
                {
                    MessageBox.Show("登入失敗", "Error", MessageBoxButtons.OK);
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine(e.ToString());
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
