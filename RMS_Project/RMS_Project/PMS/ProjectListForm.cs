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
    public partial class projectListForm : Form, FunctionalTypeInterface
    {
        private PresentationModel _presentationModel;
        private ArrayList _joinedProjects;
        private Project[] _ownedProjects;
        private Project[] _managedProjects;

        public projectListForm(PresentationModel presentationModel)
        {
            InitializeComponent();
            this._presentationModel = presentationModel;
            this._yourProjectListDataGridView.ClearSelection();
            _joinedProjects = new ArrayList();
            RefreshProjectList();
        }

        public async void RefreshProjectList()
        {
            RefreshOwnedProjectList();
            RefreshManagedProjectList();
            HttpResponseMessage response = await _presentationModel.GetProjectList();
            string content = await response.Content.ReadAsStringAsync();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                JObject json = JObject.Parse(content);
                string message = json["result"].ToString();
                JArray jsonArray = JArray.Parse(json["projects"].ToString());
                if (message == "success")
                {
                    this.joinedProjectListDataGridView.Rows.Clear();
                    foreach (JObject jObject in jsonArray)
                    {
                        this.joinedProjectListDataGridView.Rows.Add(jObject["name"]);
                        Project project = new Project(int.Parse(jObject["id"].ToString()), jObject["name"].ToString(), jObject["description"].ToString());
                        _joinedProjects.Add(project);
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

        public async void RefreshOwnedProjectList()
        {
            try
            {
                this._yourProjectListDataGridView.Rows.Clear();
                _ownedProjects = await _presentationModel.GetOwnedProjectListByUserId();
                //Console.WriteLine("count:" + _ownedProjects.Length);
                foreach (Project project in _ownedProjects)
                {
                    this._yourProjectListDataGridView.Rows.Add(project.NAME);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK);
            }
        }

        public async void RefreshManagedProjectList()
        {
            try
            {
                this._managedProjectListDataGridView.Rows.Clear();
                _managedProjects = await _presentationModel.GetManagedProjectListByUserId();
                foreach (Project project in _managedProjects)
                {
                    this._managedProjectListDataGridView.Rows.Add(project.NAME);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK);
            }
        }

        public UserInterfaceForm.FunctionalType GetFunctionalType()
        {
            return UserInterfaceForm.FunctionalType.New;
        }

        public async void DeleteProject(int projectId)
        {
            try
            {
                string message = await _presentationModel.DeleteProject(projectId);
                RefreshProjectList();
                MessageBox.Show(message, "Success", MessageBoxButtons.OK);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void _managedProjectListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn &&
                e.RowIndex >= 0)
            {
                //TODO - Button Clicked - Execute Code Here
                //Console.WriteLine("按下刪除:" + e.RowIndex);
                DeleteProject(_managedProjects[e.RowIndex].ID);
            }
            else
            {
                DataGridViewCell cell = senderGrid.Rows[e.RowIndex].Cells[0];
                Project project = _managedProjects[e.RowIndex] as Project;
                Form form = new ProjectMainForm(_presentationModel, project);
                if (_presentationModel.AddFormToPanel(form))
                {
                    _presentationModel.AddFormButtonToUserInterface(form, cell.Value.ToString(), Properties.Resources.ios7_folder_outline);
                }
            }
        }

        private void _joinedProjectListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            DataGridViewCell cell = senderGrid.Rows[e.RowIndex].Cells[0];
            Project project = _joinedProjects[e.RowIndex] as Project;
            Form form = new ProjectMainForm(_presentationModel, project);
            if (_presentationModel.AddFormToPanel(form))
            {
                _presentationModel.AddFormButtonToUserInterface(form, cell.Value.ToString(), Properties.Resources.ios7_folder_outline);
            }
        }

        private void _yourProjectListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn &&
                e.RowIndex >= 0)
            {
                //TODO - Button Clicked - Execute Code Here
                //Console.WriteLine("按下刪除:" + e.RowIndex);
                DeleteProject(_ownedProjects[e.RowIndex].ID);
            }
            else
            {
                DataGridViewCell cell = senderGrid.Rows[e.RowIndex].Cells[0];
                Project project = _ownedProjects[e.RowIndex] as Project;
                Form form = new ProjectMainForm(_presentationModel, project);
                if (_presentationModel.AddFormToPanel(form))
                {
                    _presentationModel.AddFormButtonToUserInterface(form, cell.Value.ToString(), Properties.Resources.ios7_folder_outline);
                }
            }
        }

    }
}
