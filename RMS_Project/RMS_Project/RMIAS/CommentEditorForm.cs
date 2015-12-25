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
    public partial class CommentEditorForm : Form, FunctionalTypeInterface
    {
        private Requirement _requirement;
        private PresentationModel _presentationModel;

        public CommentEditorForm( PresentationModel presentationModel, Requirement requirement)
        {
            InitializeComponent();
            _requirement = requirement;
            _presentationModel = presentationModel;
            _requirementLabel.Text = requirement.Name;
            _ownerLabel.Text = _presentationModel.GetUserName();
        }

        public UserInterfaceForm.FunctionalType GetFunctionalType()
        {
            return UserInterfaceForm.FunctionalType.Hide;
        }
    }
}
