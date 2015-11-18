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
        private const string PRIORITY = "getPriorityType";
        private const string REQUIREMENT = "getRequirementType";
        private const string STATUS = "getStatusType";

        private MainForm mainForm;
        Project project;
        private int selectedType;
        private int selectedStatus;
        private int selectedPriority;

        private List<int> pids;
        private List<string> pnames;
        private List<int> rids;
        private List<string> rnames;
        private List<int> sids;
        private List<string> snames;

        private class Item
        {
            public int id;
            public string name;

            public Item(int value, string name)
            {
                this.id = value;
                this.name = name;
            }
            public override string ToString()
            {
                // Generates the text shown in the combo box
                return name;
            }
        }

        public RequirementEditorForm(MainForm mainForm, Project project)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.project = project;

            pids = new List<int>();
            pnames = new List<string>();
            rids = new List<int>();
            rnames = new List<string>();
            sids = new List<int>();
            snames = new List<string>();


            getMethod(PRIORITY);
            getMethod(REQUIREMENT);
            getMethod(STATUS);
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            PostProduct();
        }

        private async void PostProduct()
        {
            JObject jObject = new JObject();
            jObject["name"] = textBox1.Text;
            jObject["descript"] = richTextBox2.Text;
            jObject["version"] = textBox3.Text;
            jObject["memo"] = richTextBox1.Text;
            jObject["uid"] = mainForm.UID;
            jObject["pid"] = project.id;
            jObject["type"] = selectedType;
            jObject["priority"] = selectedPriority;
            jObject["status"] = selectedStatus;

            HttpClient client = new HttpClient();

            HttpResponseMessage response;
            Console.WriteLine(jObject.ToString());
            var httpClient = new HttpClient();
            try
            {
                const string METHOD = "requirement/new";
                string url = MainForm.BASE_URL + METHOD;
                //Console.WriteLine(url);
                response = await httpClient.PostAsync(url, new StringContent(jObject.ToString(), Encoding.UTF8, "application/json"));
                string content = await response.Content.ReadAsStringAsync();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    //Console.WriteLine(content);
                    JObject json = JObject.Parse(content);
                    string message = json["result"].ToString();
                    if (message == "success")
                    {
                        mainForm.AddFormToPanel(new RequirementListForm(project));
                        MessageBox.Show("需求建立成功", "Success", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    Console.WriteLine(response.ToString());
                    MessageBox.Show("需求建立失敗", "Error", MessageBoxButtons.OK);
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
                    //Console.WriteLine(content);
                    JObject json = JObject.Parse(content);
                    string message = json["result"].ToString();
                    JArray jsonArray = null;
                    switch (method)
                    {
                        case PRIORITY:
                            jsonArray = JArray.Parse(json["priority"].ToString());
                            if (message == "success" && jsonArray != null)
                            {
                                foreach (JObject jObject in jsonArray)
                                {
                                    int id = (int)jObject["id"];
                                    string name = jObject["name"].ToString();
                                    //Console.WriteLine(name);
                                    this.pids.Add(id);
                                    this.pnames.Add(name);
                                }
                            }
                            for (int i = 0; i < pids.Count; i++)
                                priorityComboBox.Items.Add(new Item(pids.ElementAt(i), pnames.ElementAt(i)));
                            break;
                        case REQUIREMENT:
                            jsonArray = JArray.Parse(json["type"].ToString());
                            if (message == "success" && jsonArray != null)
                            {
                                foreach (JObject jObject in jsonArray)
                                {
                                    int id = (int)jObject["id"];
                                    string name = jObject["name"].ToString();
                                    //Console.WriteLine(name);
                                    this.rids.Add(id);
                                    this.rnames.Add(name);
                                }
                            }
                            for (int i = 0; i < rids.Count; i++)
                                typeComboBox.Items.Add(new Item(rids.ElementAt(i), rnames.ElementAt(i)));
                            break;
                        case STATUS:
                            jsonArray = JArray.Parse(json["statuses"].ToString());
                            if (message == "success" && jsonArray != null)
                            {
                                foreach (JObject jObject in jsonArray)
                                {
                                    int id = (int)jObject["id"];
                                    string name = jObject["name"].ToString();
                                    //Console.WriteLine(name);
                                    this.sids.Add(id);
                                    this.snames.Add(name);
                                }
                            }
                            for (int i = 0; i < sids.Count; i++)
                                statusComboBox.Items.Add(new Item(sids.ElementAt(i), snames.ElementAt(i)));
                            break;
                        default:
                            break;
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
            for (int i = 0; i < rnames.Count; i++)
            {
                if (rnames.ElementAt(i).CompareTo(typeComboBox.SelectedValue) == 0)
                {
                    selectedType = rids.ElementAt(i);
                    break;
                }
            }

        }

        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < snames.Count; i++)
            {
                if (snames.ElementAt(i).CompareTo(statusComboBox.SelectedValue) == 0)
                {
                    selectedStatus = sids.ElementAt(i);
                    break;
                }
            }
        }

        private void priorityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < pnames.Count; i++)
            {
                if (pnames.ElementAt(i).CompareTo(priorityComboBox.SelectedValue) == 0)
                {
                    selectedPriority = pids.ElementAt(i);
                    break;
                }
            }
        }

        private void RequirementEditorForm_Load(object sender, EventArgs e)
        {

        }
    }
}
