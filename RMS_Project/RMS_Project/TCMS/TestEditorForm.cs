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
    public partial class TestEditorForm : Form
    {
        private Project _project;
        private Test _test;

        public TestEditorForm(PresentationModel presentationModel, Project project)
        {
            InitializeComponent();
            _project = project;
        }

        public TestEditorForm(PresentationModel presentationModel, Project project, Test test)
        {
            InitializeComponent();
            _project = project;
            _test = test;
        }

        void confirm_Click(object sender, EventArgs e)
        {

        }

        void AddTestToProject()
        {

        }
    }
}
