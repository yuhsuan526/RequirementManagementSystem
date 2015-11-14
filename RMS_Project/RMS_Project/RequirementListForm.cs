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
    public partial class RequirementListForm : Form
    {
        private int projectId;

        public RequirementListForm(MainForm mainForm, int projectId)
        {
            InitializeComponent();

            this.projectId = projectId;

            // Add column headers so the subitems will appear.
            listView2.Columns.AddRange(new ColumnHeader[] { new ColumnHeader(), new ColumnHeader() });

            PostProduct();
        }

        private void listView1_ClientSizeChanged(object sender, EventArgs e)
        {
            listView1.TileSize = new Size(listView1.ClientSize.Width, listView1.TileSize.Height);
        }

        
        private async void PostProduct()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response;
            var httpClient = new HttpClient();
            try
            {
                const string METHOD = "project/getUserListByProject/";
                string url = MainForm.BASE_URL + METHOD + projectId.ToString();
                Console.WriteLine(url);
                response = await httpClient.GetAsync(url);
                string content = await response.Content.ReadAsStringAsync();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Console.WriteLine(content);
                    JObject json = JObject.Parse(content);
                    string message = json["result"].ToString();
                    JArray jsonArray = JArray.Parse(json["users"].ToString());
                    if (message == "success")
                    {
                        ListViewItem[] items = new ListViewItem[jsonArray.Count];
                        for (int i = 0; i < jsonArray.Count; i++)
                        {
                            JObject jObject = jsonArray[i] as JObject;
                            ListViewItem item = new ListViewItem(new string[] { jObject["name"].ToString(), jObject["id"].ToString() }, 0);
                            items[i] = item;
                        }
                        listView2.Items.AddRange(items);
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

        private void listView2_ClientSizeChanged(object sender, EventArgs e)
        {
            listView2.TileSize = new Size(listView2.ClientSize.Width, listView2.TileSize.Height);
        }
        
    }
}
