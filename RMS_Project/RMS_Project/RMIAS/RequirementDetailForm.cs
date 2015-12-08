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
    public partial class RequirementDetailForm : BasicForm
    {
        public RequirementDetailForm(Requirement requirement, Panel parentPanel) : base(parentPanel)
        {
            InitializeComponent();
            
            numberLabel.Text = requirement.ID.ToString();
            nameLabel.Text = requirement.NAME;
            descriptionLabel.Text = requirement.DESC;
            memoLabel.Text = requirement.MEMO;
        }
    }
}
