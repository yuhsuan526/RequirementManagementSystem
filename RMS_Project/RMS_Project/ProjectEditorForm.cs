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
    public partial class ProjectEditorForm : Form
    {
        private MainForm mainForm;

        public ProjectEditorForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PostProduct();
        }

        private async void PostProduct()
        {
            JObject jObject = new JObject();
            jObject["name"] = textBox1.Text;
            jObject["descript"] = richTextBox1.Text;
            jObject["uid"] = mainForm._model.UID;

            string status = await mainForm._model.AddProject(jObject);
            if (status == "success")
            {
                mainForm.AddFormToPanel(new ProjectListForm(mainForm));
                MessageBox.Show("專案建立成功", "Success", MessageBoxButtons.OK);
            }
            else if (status == "專案建立失敗")
            {
                MessageBox.Show("專案建立失敗", "Error", MessageBoxButtons.OK);
            }
            else if (status == "伺服器無回應")
            {
                MessageBox.Show("伺服器無回應", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
