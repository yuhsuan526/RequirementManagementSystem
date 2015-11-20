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
    public partial class RegistrantionForm : Form
    {
        private MainForm mainForm;
        public RegistrantionForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private async void PostProduct()
        {
            JObject jObject = new JObject();
            jObject["name"] = userName.Text;
            jObject["email"] = email.Text;
            jObject["password"] = password.Text;

            string status = await mainForm._model.Registry(jObject);
            if (status == "success")
            {
                mainForm.AddFormToPanel(new LoginForm(mainForm));
                MessageBox.Show("註冊成功", "Success", MessageBoxButtons.OK);
            }
            else if (status == "註冊失敗")
            {
                MessageBox.Show("註冊失敗", "Error", MessageBoxButtons.OK);
            }
            else if (status == "伺服器無回應")
            {
                MessageBox.Show("伺服器無回應", "Error", MessageBoxButtons.OK);
            }
            /*
            HttpClient client = new HttpClient();

            HttpResponseMessage response;
            Console.WriteLine(jObject.ToString());
            var httpClient = new HttpClient();
            try
            {
                response = await httpClient.PostAsync("http://140.124.183.32:3000/user/register", new StringContent(jObject.ToString(), Encoding.UTF8, "application/json"));
                string content = await response.Content.ReadAsStringAsync();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Console.WriteLine(content);
                    JObject json = JObject.Parse(content);
                    string message = json["result"].ToString();
                    if (message == "success")
                    {
                        mainForm.AddFormToPanel(new LoginForm(mainForm));
                        MessageBox.Show("註冊成功", "Success", MessageBoxButtons.OK);

                    }
                    else
                    {
                        MessageBox.Show("註冊失敗", "Error", MessageBoxButtons.OK);

                    }
                }
                else
                {
                    MessageBox.Show("註冊失敗", "Error", MessageBoxButtons.OK);
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine(e.ToString());
                MessageBox.Show("伺服器無回應", "Error", MessageBoxButtons.OK);
            }*/
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            mainForm.AddFormToPanel(new LoginForm(mainForm));
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (password.Text.Equals(confirmPasswordTextBox.Text))
                PostProduct();
            else
            {
                password.Text = "";
                confirmPasswordTextBox.Text = "";
                MessageBox.Show("密碼不一致，請在確認一次", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
