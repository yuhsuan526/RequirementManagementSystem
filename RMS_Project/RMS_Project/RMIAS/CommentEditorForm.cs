using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS_Project.RMIAS
{
    public partial class CommentEditorForm : Form
    {
        private Requirement _requirement;
        private PresentationModel _presentationModel;

        public CommentEditorForm(Requirement requirement, PresentationModel presentationModel)
        {
            InitializeComponent();
            _requirement = requirement;
            _presentationModel = presentationModel;
        }
    }
}
