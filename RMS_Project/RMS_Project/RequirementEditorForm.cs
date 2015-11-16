using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Net.Http;

namespace RMS_Project
{
    public partial class RequirementEditorForm : Form
    {
        private MainForm mainForm;
        Project project;
        private int selectedType;
        private int selectedStatus;
        private int selectedPriority;
        private List<int> ids;
        private List<string> names; 

        public RequirementEditorForm(MainForm mainForm, Project project)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.project = project;
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            PostProduct();
        }

        private async void PostProduct()
        {
            JObject jObject = new JObject();
            jObject["name"] = textBox1.Text;
            jObject["type"] = selectedType;
            jObject["version"] = textBox3.Text;
            jObject["priority"] = selectedPriority;
            jObject["status"] = selectedStatus;
            jObject["descript"] = richTextBox2.Text;
            jObject["memo"] = richTextBox1.Text;
            jObject["uid"] = mainForm.UID;
            jObject["pid"] = project.id;

            HttpClient client = new HttpClient();

            HttpResponseMessage response;
            Console.WriteLine(jObject.ToString());
            var httpClient = new HttpClient();
            try
            {
                const string METHOD = "project/new";
                string url = MainForm.BASE_URL + METHOD;
                Console.WriteLine(url);
                response = await httpClient.PostAsync(url, new StringContent(jObject.ToString(), Encoding.UTF8, "application/json"));
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

        private async void getMethod(String method)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response;
            var httpClient = new HttpClient();
            try
            {
                const string METHOD = "requirement/";
                string url = MainForm.BASE_URL + METHOD + method;
                Console.WriteLine(url);
                response = await httpClient.GetAsync(url);
                string content = await response.Content.ReadAsStringAsync();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Console.WriteLine(content);
                    JObject json = JObject.Parse(content);
                    string message = json["result"].ToString();
                    JArray jsonArray = null;
                    switch (method)
                    {
                        case "getPriorityType":
                            jsonArray = JArray.Parse(json["priority"].ToString());
                            break;
                        case "getRequirementType":
                            jsonArray = JArray.Parse(json["type"].ToString());
                            break;
                        case "getStatusType":
                            jsonArray = JArray.Parse(json["statuses"].ToString());
                            break;
                        default:
                            break;
                    }

                    if (message == "success" && jsonArray!=null)
                    {
                        foreach (JObject jObject in jsonArray)
                        {
                            int id = (int) jObject["id"];
                            string name = jObject["name"].ToString();
                            this.ids.Add(id);
                            this.names.Add(name);
                            //this.ProjectListDataGridView.Rows.Add(jObject["name"], jObject["id"]);
                            //Project project = new Project(int.Parse(jObject["id"].ToString()), jObject["name"].ToString(), jObject["descript"].ToString());
                           // array.Add(project);
                        }
                    }
                }
                else
                {
                    Console.WriteLine(response.ToString());
                    MessageBox.Show("伺服器錯誤", "Error", MessageBoxButtons.OK);
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine(e.ToString());
                MessageBox.Show("伺服器無回應", "Error", MessageBoxButtons.OK);
            }
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void priorityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
