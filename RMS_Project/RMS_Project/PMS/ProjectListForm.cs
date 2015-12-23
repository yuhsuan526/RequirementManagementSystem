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
    public partial class ProjectListForm : Form, FunctionalTypeInterface
    {
        private PresentationModel _presentationModel;
        private ArrayList _arrayList;
        private Project[] ownedProjects;
        private Project[] managedProjects;

        public ProjectListForm(PresentationModel presentationModel)
        {
            InitializeComponent();
            this._presentationModel = presentationModel;
            this._yourProjectListDataGridView.ClearSelection();
            _arrayList = new ArrayList();
            RefreshProjectList();
        }

        private void ProjectListDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            DataGridViewCell cell = ProjectListDataGridView.Rows[e.RowIndex].Cells[0];
            Project project = _arrayList[e.RowIndex] as Project;
            Form form = new ProjectMainForm(_presentationModel, project);
            if (_presentationModel.AddFormToPanel(form))
            {
                UserInterfaceForm userInterface = _presentationModel.UserInterface;
                if (userInterface != null)
                {
                    userInterface.SetFeatureButton(UserInterfaceForm.FeatureType.Edit);
                }
                _presentationModel.AddFormButtonToUserInterface(form, cell.Value.ToString(), Properties.Resources.ios7_folder_outline);
            }*/
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
                    this._joinedProjectListDataGridView.Rows.Clear();
                    foreach (JObject jObject in jsonArray)
                    {
                        this._joinedProjectListDataGridView.Rows.Add(jObject["name"]);
                        Project project = new Project(int.Parse(jObject["id"].ToString()), jObject["name"].ToString(), jObject["description"].ToString());
                        _arrayList.Add(project);
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
                ownedProjects = await _presentationModel.GetOwnedProjectListByUserId();
                Console.WriteLine("count:" + ownedProjects.Length);
                foreach (Project project in ownedProjects)
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
                managedProjects = await _presentationModel.GetManagedProjectListByUserId();
                foreach (Project project in managedProjects)
                {
                    this._managedProjectListDataGridView.Rows.Add(project.NAME);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK);
            }
        }

        void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void ProjectListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn &&
                e.RowIndex >= 0)
            {
                //TODO - Button Clicked - Execute Code Here
                Console.WriteLine("按下刪除:" + e.RowIndex);
                //_presentationModel.DeleteProject(_arrayList[e.RowIndex])
            }
            else
            {
                DataGridViewCell cell = _yourProjectListDataGridView.Rows[e.RowIndex].Cells[0];
                Project project = _arrayList[e.RowIndex] as Project;
                Form form = new ProjectMainForm(_presentationModel, project);
                if (_presentationModel.AddFormToPanel(form))
                {
                    _presentationModel.AddFormButtonToUserInterface(form, cell.Value.ToString(), Properties.Resources.ios7_folder_outline);
                }
            }
        }

        public UserInterfaceForm.FunctionalType GetFunctionalType()
        {
            return UserInterfaceForm.FunctionalType.New;
        }
    }
}
