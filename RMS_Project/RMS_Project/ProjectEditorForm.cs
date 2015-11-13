using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS_Project
{
    public partial class ProjectEditorForm : Form
    {
        private MainForm mainForm;

        public ProjectEditorForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PostProduct();
        }

        private async void PostProduct()
        {
            JObject jObject = new JObject();
            jObject["name"] = textBox1.Text;
            jObject["descript"] = richTextBox1.Text;
            jObject["uid"] = mainForm.UID;

            HttpClient client = new HttpClient();

            HttpResponseMessage response;
            Console.WriteLine(jObject.ToString());
            var httpClient = new HttpClient();
            try
            {
                const string METHOD = "project/new";
                string url = MainForm.BASE_URL + METHOD;
                Console.WriteLine(url);
                response = await httpClient.PostAsync(url , new StringContent(jObject.ToString(), Encoding.UTF8, "application/json"));
                string content = await response.Content.ReadAsStringAsync();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Console.WriteLine(content);
                    JObject json = JObject.Parse(content);
                    string message = json["result"].ToString();
                    if (message == "success")
                    {
                        mainForm.AddFormToPanel(new ProjectListForm(mainForm));
                        MessageBox.Show("專案建立成功", "Success", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    Console.WriteLine(response.ToString());
                    MessageBox.Show("專案建立失敗", "Error", MessageBoxButtons.OK);
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine(e.ToString());
                MessageBox.Show("伺服器無回應", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
