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
            this._requirement = requirement;
            
        }

        public void RefreshRequirementDetail(Requirement requirement)
        {
            this._requirement = requirement;
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
