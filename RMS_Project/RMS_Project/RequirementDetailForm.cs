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
        public RequirementDetailForm(Requirement requirement)
        {
            InitializeComponent();
            
            numberLabel.Text = requirement.id.ToString();
            nameLabel.Text = requirement.name;
            descriptionLabel.Text = requirement.description;
            memoLabel.Text = requirement.memo;
        }
    }
}
