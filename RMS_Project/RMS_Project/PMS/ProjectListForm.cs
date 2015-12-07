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
    public partial class ProjectListForm : Form
    {
        private PresentationModel _presentationModel;
        private ArrayList _arrayList;

        public ProjectListForm(PresentationModel presentationModel)
        {
            InitializeComponent();
            this._presentationModel = presentationModel;
            this.ProjectListDataGridView.ClearSelection();
            _arrayList = new ArrayList();
            RefreshProjectList();
        }

        private void ProjectListDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = ProjectListDataGridView.Rows[e.RowIndex].Cells[0];
            Project project = _arrayList[e.RowIndex] as Project;
            Form form = new ProjectMainForm(_presentationModel, project);
            if (_presentationModel.AddFormToPanel(form))
                _presentationModel.AddFormButtonToUserInterface(form, cell.Value.ToString(), Properties.Resources.ios7_folder_outline);
        }

        public async void RefreshProjectList()
        {
            HttpResponseMessage response = await _presentationModel.Model.GetProjectList();
            string content = await response.Content.ReadAsStringAsync();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                JObject json = JObject.Parse(content);
                string message = json["result"].ToString();
                JArray jsonArray = JArray.Parse(json["projects"].ToString());
                if (message == "success")
                {
                    this.ProjectListDataGridView.Rows.Clear();
                    foreach (JObject jObject in jsonArray)
                    {
                        this.ProjectListDataGridView.Rows.Add(jObject["name"], jObject["id"]);
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
    }
}
