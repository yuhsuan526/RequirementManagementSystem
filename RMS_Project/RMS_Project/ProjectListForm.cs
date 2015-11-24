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
        private MainForm mainForm;
        private ArrayList array;

        public ProjectListForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.ProjectListDataGridView.ClearSelection();
            array = new ArrayList();
            RefreshProjectList();
        }

        private void ProjectListDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = ProjectListDataGridView.Rows[e.RowIndex].Cells[0];
            Project project = array[e.RowIndex] as Project;
            Form form = new ProjectMainForm(mainForm, project);
            if(mainForm.AddFormToPanel(form))
                mainForm.AddFormButtonToUserInterface(form, cell.Value.ToString(), Properties.Resources.ios7_folder_outline);
        }


        public async void RefreshProjectList()
        {
            HttpResponseMessage response = await mainForm._model.GetProjectList();
            string content = await response.Content.ReadAsStringAsync();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                JObject json = JObject.Parse(content);
                string message = json["result"].ToString();
                JArray jsonArray = JArray.Parse(json["projects"].ToString());
                if (message == "success")
                {
                    foreach (JObject jObject in jsonArray)
                    {
                        this.ProjectListDataGridView.Rows.Add(jObject["name"], jObject["id"]);
                        Project project = new Project(int.Parse(jObject["id"].ToString()), jObject["name"].ToString(), jObject["descript"].ToString());
                        array.Add(project);
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

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
