using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS_Project
{
    public partial class ProjectDetailForm : Form
    {
        private Project project;

        public ProjectDetailForm(Project project)
        {
            InitializeComponent();
            this.project = project;
            nameLabel.Text = project.name;
            descriptionLabel.Text = project.description;
            numberLabel.Text = project.id.ToString();
        }
    }
}
