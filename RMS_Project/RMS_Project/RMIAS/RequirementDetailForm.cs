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
    public partial class RequirementDetailForm : Form
    {
        private Requirement _requirement;
        private Project _project;

        public RequirementDetailForm(Project project, Requirement requirement)
        {
            InitializeComponent();
            _requirement = requirement;
            _project = project;
            _nameLabel.Text = requirement.ID.ToString() + ": " + requirement.NAME;
            _descriptionRichTextBox.Text = requirement.DESC;
            _memoRichTextBox.Text = requirement.MEMO;
        }

        public void RefreshRequirementDetail(Requirement requirement)
        {

        }

        public Requirement Requirement
        {
            get
            {
                return _requirement;
            }
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
