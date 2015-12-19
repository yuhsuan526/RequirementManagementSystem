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
        private LoginForm _loginForm;

        //Constructor
        public MainForm()
        {
            InitializeComponent();
            _presentationModel = new PresentationModel(this);
            _loginForm = new LoginForm(_presentationModel);
            _presentationModel.AddFormToPanel(_loginForm);
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
        
        public LoginForm LoginForm
        {
            get
            {
                return _loginForm;
            }
        }
    }
}
