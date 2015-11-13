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
    public partial class ProjectListForm : Form
    {
        private MainForm mainForm;

        public ProjectListForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.ProjectListDataGridView.ClearSelection();
            PostProduct();
        }

        private void ProjectListDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = ProjectListDataGridView.Rows[e.RowIndex].Cells[0];
            Form form = new RequirementListForm();
            mainForm.AddFormToPanel(form);
            mainForm.AddFormButtonToUserInterface(form, cell.Value.ToString(), Properties.Resources.ios7_paper_outline);
        }


        private async void PostProduct()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response;
            var httpClient = new HttpClient();
            try
            {
                const string METHOD = "project/list/";
                string url = MainForm.BASE_URL + METHOD + mainForm.UID.ToString();
                Console.WriteLine(url);
                response = await httpClient.GetAsync(url);
                string content = await response.Content.ReadAsStringAsync();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Console.WriteLine(content);
                    JObject json = JObject.Parse(content);
                    string message = json["result"].ToString();
                    JArray jsonArray = JArray.Parse(json["projects"].ToString());
                    if (message == "success")
                    {
                        foreach (JObject jObject in jsonArray)
                        {
                            this.ProjectListDataGridView.Rows.Add(jObject["name"], jObject["updated_at"]);
                        }
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
