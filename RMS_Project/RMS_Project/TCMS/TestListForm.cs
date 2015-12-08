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
    public partial class TestListForm : BasicForm
    {
        private PresentationModel _presentationModel;
        private Project _project;

        public TestListForm(PresentationModel presentationModel, Project project, Panel panel) : base(panel)
        {
            InitializeComponent();
            this._presentationModel = presentationModel;
            this._project = project;
            this.testListDataGridView.Rows.Add("test", "yyyy/mm/dd");
        }
    }
}
