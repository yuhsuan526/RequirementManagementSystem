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
    public partial class MainForm : Form
    {
        private PresentationModel _presentationModel;
        private UserInterfaceForm _userInterface;
        private LoginForm _loginForm;

        //Constructor
        public MainForm()
        {
            InitializeComponent();
            _presentationModel = new PresentationModel(this);
            _loginForm = new LoginForm(_presentationModel);
            _presentationModel.AddFormToPanel(_loginForm);
            _presentationModel.AddFormToNavigationPanel(new DefaultInterfaceForm());
        }

        public Panel MainFormPanel
        {
            get
            {
                return _mainFormPanel;
            }
        }

        public Panel NavigationPanel
        {
            get
            {
                return _navigationPanel;
            }
        }

        public UserInterfaceForm UserInterface
        {
            get
            {
                return _userInterface;
            }
        }
        
        public void SignOut()
        {
            if (_presentationModel.PopFormsFromPanel(_loginForm))
            {
                _presentationModel.ModelSignOut();
                _presentationModel.PopFormFromNavigationPanelAnimated();
                this._userInterface = null;
            }
        }
    }
}
