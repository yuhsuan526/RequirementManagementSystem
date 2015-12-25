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
            RefreshRequirementDetail(requirement);
        }

        public void RefreshRequirementDetail(Requirement requirement)
        {
            this._requirement = requirement;
            idLabel.Text = _requirement.ID.ToString();
            nameLabel.Text = _requirement.Name;
            versionLabel.Text = _requirement.Version;
            typeLabel.Text = _requirement.Type.ToString();
            priorityLabel.Text = _requirement.Priority.ToString();
            statusLabel.Text = _requirement.Status.ToString();
            requirementOwnerLabel.Text = _requirement.Owner.Name;
            handlerLabel.Text = _requirement.Handler.Name;
            descriptionTextBox.Text = _requirement.Description;
            memoTextBox.Text = _requirement.Memo;

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
