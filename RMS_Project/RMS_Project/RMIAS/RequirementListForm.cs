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
    public partial class RequirementListForm : Form
    {
        private PresentationModel _presentationModel;
        private Project _project;
        private ArrayList _arrayList;

        public RequirementListForm(PresentationModel presentationModel, Project project)
        {
            InitializeComponent();
            this._presentationModel = presentationModel;
            this._project = project;
            this.requirementListDataGridView.ClearSelection();
            _arrayList = new ArrayList();
            GetRequirementByProject();
        }

        private async void GetRequirementByProject()
        {
            HttpResponseMessage response = await _presentationModel.GetRequirementByProject(_project.ID.ToString());
            string content = await response.Content.ReadAsStringAsync();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                JObject json = JObject.Parse(content);
                string message = json["result"].ToString();
                JArray jsonArray = JArray.Parse(json["requirements"].ToString());
                if (message == "success")
                {
                    this.requirementListDataGridView.Rows.Clear();
                    foreach (JObject jObject in jsonArray)
                    {
                        this.requirementListDataGridView.Rows.Add(jObject["name"], jObject["updated_at"]);
                        Requirement requirement = new Requirement((int)jObject["id"], jObject["name"].ToString(), jObject["description"].ToString(), jObject["version"].ToString(), jObject["memo"].ToString());
                        _arrayList.Add(requirement);
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

        private void requirementListDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = requirementListDataGridView.Rows[e.RowIndex].Cells[0];
            Requirement requirement = _arrayList[e.RowIndex] as Requirement;
            Form form = new RequirementDetailForm(_project, requirement);
            if (_presentationModel.AddFormToPanel(form))
                _presentationModel.AddFormButtonToUserInterface(form, cell.Value.ToString(), Properties.Resources.ios7_paper_outline);
        }

        void deleteButton_Click(object sender, EventArgs e)
        {

        }

        void RefreshRequirementList()
        {

        }

        public Project Project
        {
            get
            {
                return _project;
            }
        }
    }
}
