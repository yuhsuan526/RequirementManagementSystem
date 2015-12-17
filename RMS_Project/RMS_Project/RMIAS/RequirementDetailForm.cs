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
            
            _nameLabel.Text = requirement.ID.ToString() + ": " + requirement.NAME;
            _descriptionRichTextBox.Text = requirement.DESC;
            _memoRichTextBox.Text = requirement.MEMO;
        }
    }
}
