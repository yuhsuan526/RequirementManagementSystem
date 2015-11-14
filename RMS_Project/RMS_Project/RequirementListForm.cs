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
    public partial class RequirementListForm : Form
    {
        private Project project;

        public RequirementListForm(Project project)
        {
            InitializeComponent();
            this.project = project;
        }

        private void listView1_ClientSizeChanged(object sender, EventArgs e)
        {
            listView1.TileSize = new Size(listView1.ClientSize.Width, listView1.TileSize.Height);
        }
        
    }
}
