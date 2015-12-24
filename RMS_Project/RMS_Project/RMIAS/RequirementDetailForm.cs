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
    public partial class RequirementDetailForm : Form, FunctionalTypeInterface
    {
        private Requirement _requirement;

        public RequirementDetailForm(Requirement requirement)
        {
            InitializeComponent();
            _requirement = requirement;
 
            _nameLabel.Text = requirement.ID.ToString() + ": " + requirement.Name;
            _descriptionTextBox.Text = requirement.Description;
            _memoTextBox.Text = requirement.Memo;
        }

        public void RefreshRequirementDetail(Requirement requirement)
        {
            this._requirement = requirement;
            _descriptionTextBox.Text = _requirement.Description;
            _memoTextBox.Text = _requirement.Memo;
        }

        public Requirement Requirement
        {
            get
            {
                return _requirement;
            }
        }

        public UserInterfaceForm.FunctionalType GetFunctionalType()
        {
            return UserInterfaceForm.FunctionalType.Edit;
        }
    }
}
