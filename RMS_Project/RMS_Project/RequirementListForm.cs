using Newtonsoft.Json.Linq;
using System;
using System.Collections;
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
    public partial class RequirementListForm : Form
    {
        private Project project;
        private ArrayList array;

        public RequirementListForm(Project project)
        {
            InitializeComponent();
            this.project = project;
            this.requirementListDataGridView.ClearSelection();
            array = new ArrayList();
            GetRequirementByProject();
        }

        private async void GetRequirementByProject()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response;
            var httpClient = new HttpClient();
            try
            {
                const string METHOD = "project/getRequirementByProject/";
                string url = MainForm.BASE_URL + METHOD + project.id.ToString();
                Console.WriteLine(url);
                response = await httpClient.GetAsync(url);
                string content = await response.Content.ReadAsStringAsync();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Console.WriteLine(content);
                    JObject json = JObject.Parse(content);
                    string message = json["result"].ToString();
                    JArray jsonArray = JArray.Parse(json["requirements"].ToString());
                    if (message == "success")
                    {
                        foreach (JObject jObject in jsonArray)
                        {
                            this.requirementListDataGridView.Rows.Add(jObject["name"], jObject["id"]);
                            //Project project = new Project(int.Parse(jObject["id"].ToString()), jObject["name"].ToString(), jObject["descript"].ToString());
                            //array.Add(project);
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
    }
}
