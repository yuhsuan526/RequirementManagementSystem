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
    public partial class UserListForm : Form, FunctionalTypeInterface
    {
        private Project _project;
        private PresentationModel _presentationModel;
        private ArrayList _arrayList;

        public UserListForm(PresentationModel presentationModel, Project project)
        {
            InitializeComponent();
            this._project = project;
            this._presentationModel = presentationModel;
            this._arrayList = new ArrayList();
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
                    _userListDataGridView.Rows.Clear();
                    for (int i = 0; i < jsonArray.Count; i++)
                    {
                        JObject jObject = jsonArray[i] as JObject;
                        this._userListDataGridView.Rows.Add(jObject["name"], jObject["email"]);
                        _arrayList.Add(jObject);
                    }
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

        private void addUserButton_Click(object sender, EventArgs e)
        {
            if (!userTextBox.Text.Equals(""))
                AddUserToProject();
        }

        private async void AddUserToProject()
        {
            JObject jObject = new JObject();
            jObject["add_email"] = userTextBox.Text;
            jObject["uid"] = _presentationModel.GetUID();
            jObject["pid"] = _project.ID;

            HttpResponseMessage response = await _presentationModel.AddUserToProject(jObject);

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

        public UserInterfaceForm.FunctionalType GetFunctionalType()
        {
            return UserInterfaceForm.FunctionalType.Hide;
        }
    }
}
