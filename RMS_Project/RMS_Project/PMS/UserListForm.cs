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
        private NormalAttribute[] _priorities;

        public UserListForm(PresentationModel presentationModel, Project project)
        {
            InitializeComponent();
            this._project = project;
            this._presentationModel = presentationModel;
            this._arrayList = new ArrayList();
            _userListDataGridView.Columns[2].Visible = false;
            GetUserListByProject();
            GetProjectPriorityType();
        }

        private async void GetProjectPriorityType()
        {
            _priorities = await _presentationModel.GetProjectPriorityType();
            foreach (NormalAttribute priority in _priorities)
            {
                _priorityComboBox.Items.Add(priority.Name);
            }
            _priorityComboBox.SelectedIndex = _priorities.Length - 1;
        }

        private async void DeleteUserFormProject(int userId)
        {
            string message;
            try
            {
                if (userId == _presentationModel.GetUID())
                {
                    MessageBox.Show("無法刪除自己", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    message = await _presentationModel.DeleteUserFromProject(_project.ID, userId);
                    GetUserListByProject();
                    MessageBox.Show(message, "Success", MessageBoxButtons.OK);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK);
            }
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
                        this._userListDataGridView.Rows.Add(jObject["name"], jObject["priority_type_name"]);
                        _arrayList.Add(jObject);
                        if (jObject["id"].ToString().Equals(_presentationModel.GetUID().ToString()))
                        {
                            _userListDataGridView.Columns[2].Visible = jObject["priority_type_name"].ToString().Equals("Owner")
                                || jObject["priority_type_name"].ToString().Equals("Manager");
                        }
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

        public void AddUser()
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
            jObject["priority_type_id"] = _priorities[_priorityComboBox.SelectedIndex].ID;

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
            return UserInterfaceForm.FunctionalType.New;
        }

        private void _userListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn &&
                e.RowIndex >= 0)
            {
                JObject jObect = _arrayList[e.RowIndex] as JObject;
                DeleteUserFormProject(int.Parse(jObect["id"].ToString()));
            }
        }
    }
}
