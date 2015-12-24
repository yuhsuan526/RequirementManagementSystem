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
    public partial class TestEditorForm : Form, FunctionalTypeInterface
    {
        private Project _project;
        private Test _test;

        public TestEditorForm(PresentationModel presentationModel, Project project)
        {
            InitializeComponent();
            _project = project;
        }

        public TestEditorForm(PresentationModel presentationModel, Test test)
        {
            InitializeComponent();
            _test = test;
        }

        void confirm_Click(object sender, EventArgs e)
        {

        }

        void AddTestToProject()
        {

        }

        public UserInterfaceForm.FunctionalType GetFunctionalType()
        {
            return UserInterfaceForm.FunctionalType.Hide;
        }
    }
}
