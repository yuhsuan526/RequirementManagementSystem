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


            GetMethod(PRIORITY);
            GetMethod(REQUIREMENT);
            GetMethod(STATUS);
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            PostProduct();
        }

        private async void PostProduct()
        {
            JObject jObject = new JObject();
            jObject["name"] = textBox1.Text;
            jObject["description"] = richTextBox2.Text;
            jObject["version"] = textBox3.Text;
            jObject["memo"] = richTextBox1.Text;
            jObject["uid"] = mainForm._model.UID;
            jObject["pid"] = project.id;
            jObject["type"] = selectedType;
            jObject["priority"] = selectedPriority;
            jObject["status"] = selectedStatus;

            string status = await mainForm._model.AddRequirement(jObject);
            if (status == "success")
            {
                mainForm.AddFormToPanel(new RequirementListForm(mainForm, project));
                MessageBox.Show("需求建立成功", "Success", MessageBoxButtons.OK);
            }
            else if (status == "需求建立失敗")
            {
                MessageBox.Show("需求建立失敗", "Error", MessageBoxButtons.OK);
            }
            else if (status == "伺服器無回應")
            {
                MessageBox.Show("伺服器無回應", "Error", MessageBoxButtons.OK);
            }
        }

        private async void GetMethod(String method)
        {
            HttpResponseMessage response = await mainForm._model.GetMethod(method);

            string content = await response.Content.ReadAsStringAsync();
            if (response.StatusCode == HttpStatusCode.OK)
            {
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
            else if (response.StatusCode == HttpStatusCode.RequestTimeout)
            {
                MessageBox.Show("伺服器無回應", "Error", MessageBoxButtons.OK);
            }
            else
            {
                Console.WriteLine(response.ToString());
                MessageBox.Show("伺服器錯誤", "Error", MessageBoxButtons.OK);
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
