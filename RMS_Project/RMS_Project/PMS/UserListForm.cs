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
    public partial class UserListForm : Form
    {
        private Project _project;
        private PresentationModel _presentationModel;

        public UserListForm(PresentationModel presentationModel, Project project)
        {
            InitializeComponent();
            this._project = project;
            this._presentationModel = presentationModel;
            userListView.Columns.AddRange(new ColumnHeader[] { new ColumnHeader(), new ColumnHeader() });
            GetUserListByProject();
        }

        private async void GetUserListByProject()
        {
            HttpResponseMessage response = await _presentationModel.GetUserListByProject(_project.ID.ToString());
            string content = await response.Content.ReadAsStringAsync();
            if (response.StatusCode == HttpStatusCode.OK)
            {
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
            else if (response.StatusCode == HttpStatusCode.RequestTimeout)
            {
                MessageBox.Show("伺服器無回應", "Error", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("伺服器錯誤", "Error", MessageBoxButtons.OK);
            }
        }

        private void userListView_ClientSizeChanged(object sender, EventArgs e)
        {
            userListView.TileSize = new Size(userListView.ClientSize.Width, userListView.TileSize.Height);
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            if (!userTextBox.Text.Equals(""))
                PostAddUserToProject();
        }

        private async void PostAddUserToProject()
        {
            JObject jObject = new JObject();
            jObject["add_email"] = userTextBox.Text;
            jObject["uid"] = _presentationModel.GetUID();
            jObject["pid"] = _project.ID;

            HttpResponseMessage response = await _presentationModel.PostAddUserToProject(jObject);

            string content = await response.Content.ReadAsStringAsync();
            if (response.StatusCode == HttpStatusCode.OK)
            {
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
            else if (response.StatusCode == HttpStatusCode.RequestTimeout)
            {
                MessageBox.Show("伺服器無回應", "Error", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("加入失敗", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
