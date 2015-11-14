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
    public partial class ProjectMainForm : Form
    {
        MainForm mainForm;
        Project project;
        private ProjectDetailForm projectDetailForm;
        private RequirementListForm requirementListForm;

        public ProjectMainForm(MainForm mainForm, Project project)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.project = project;
            userListView.Columns.AddRange(new ColumnHeader[] { new ColumnHeader(), new ColumnHeader() });
            projectDetailForm = new ProjectDetailForm(project);
            requirementListForm = new RequirementListForm(project);
            AddFormToPanel(projectDetailForm);
            UserInterfaceForm form = mainForm.GetUserInterface();
            if (form != null)
            {
                form.SetFeatureButton(UserInterfaceForm.FeatureType.Edit);
            }
            GetUserListByProject();
        }

        public void AddFormToPanel(Form form)
        {
            form.TopLevel = false;
            while (mainPanel.Controls.Count > 0)
                mainPanel.Controls.RemoveAt(mainPanel.Controls.Count - 1);
            mainPanel.Controls.Add(form);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private async void GetUserListByProject()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response;
            var httpClient = new HttpClient();
            try
            {
                const string METHOD = "project/getUserListByProject/";
                string url = MainForm.BASE_URL + METHOD + project.id.ToString();
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
                            ListViewItem item = new ListViewItem(new string[] { jObject["name"].ToString(), jObject["email"].ToString() }, 0);
                            items[i] = item;
                        }
                        userListView.Items.Clear();
                        userListView.Items.AddRange(items);
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

        private void userListView_ClientSizeChanged(object sender, EventArgs e)
        {
            userListView.TileSize = new Size(userListView.ClientSize.Width, userListView.TileSize.Height);
        }

        public void ClickNewButton()
        {
            switch (projectTabControl.SelectedTab.Text)
            {
                case "users":
                    break;
                case "requirements":
                    AddFormToPanel(new RequirementEditorForm());
                    break;
                case "tests":
                    break;
                case "others":
                    break;
            }
        }

        private void projectTabControl_Selected(object sender, TabControlEventArgs e)
        {
            UserInterfaceForm form = mainForm.GetUserInterface();
            switch (projectTabControl.SelectedTab.Text)
            {
                case "users":
                    AddFormToPanel(projectDetailForm);
                    if (form != null)
                    {
                        form.SetFeatureButton(UserInterfaceForm.FeatureType.Edit);
                    }
                    break;
                case "requirements":
                    AddFormToPanel(requirementListForm);
                    if (form != null)
                    {
                        form.SetFeatureButton(UserInterfaceForm.FeatureType.New);
                    }
                    break;
                case "tests":
                    if (form != null)
                    {
                        form.SetFeatureButton(UserInterfaceForm.FeatureType.New);
                    }
                    break;
                case "others":
                    if (form != null)
                    {
                        form.SetFeatureButton(UserInterfaceForm.FeatureType.Hide);
                    }
                    break;
            }
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            if(!userTextBox.Text.Equals(""))
                PostAddUserToProject();
        }

        private async void PostAddUserToProject()
        {
            JObject jObject = new JObject();
            jObject["add_email"] = userTextBox.Text;
            jObject["uid"] = mainForm.UID;
            jObject["pid"] = project.id;

            HttpClient client = new HttpClient();

            HttpResponseMessage response;
            Console.WriteLine(jObject.ToString());
            var httpClient = new HttpClient();
            try
            {
                const string METHOD = "project/addUserToProject";
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
                        userTextBox.Text = "";
                        GetUserListByProject();
                        MessageBox.Show("加入成功", "Success", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show(json["message"].ToString(), "Error", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    Console.WriteLine(response.ToString());
                    MessageBox.Show("加入失敗", "Error", MessageBoxButtons.OK);
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine(e.ToString());
                MessageBox.Show("伺服器無回應", "Error", MessageBoxButtons.OK);
            }
        }
    }

    public class Project
    {
        public Project(int id, string name, string description)
        {
            this.id = id;
            this.name = name;
            this.description = description;
        }
        public int id;
        public string name;
        public string description;
    }
}
