using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS_Project
{
    public class PresentationModel
    {
        private Model _model;
        private MainForm _mainForm;
        private Panel _mainFormPanel;
        private Panel _navigationPanel;
        private UserInterfaceForm _userInterface;

        private bool isAnimating = false;

        public PresentationModel(MainForm mainform)
        {
            _model = new Model();
            _mainForm = mainform;
            _mainFormPanel = mainform.MainFormPanel;
            _navigationPanel = mainform.NavigationPanel;
        }

        /*public Model Model
        {
            get
            {
                return _model;
            }
        }*/

        //Add form to mainFormPanel
        public bool AddFormToPanel(Form form)
        {
            if (isAnimating)
            {
                return false;
            }
            form.TopLevel = false;
            _mainFormPanel.Controls.Add(form);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
            if (_mainFormPanel.Controls.Count > 1)
            {
                Util.Animate(_mainFormPanel.Controls[_mainFormPanel.Controls.Count - 2], Util.Effect.Slide, 500, 180);
                waitForAnimation(500);
                return true;
            }
            return false;
        }

        public async Task<string> SignIn(JObject jObject)        
        {
            string status = await _model.SignIn(jObject);
            if (status == "success")
            {
                UserInterfaceForm form = new UserInterfaceForm(this);
                AddFormToNavigationPanel(form);
                _userInterface = form;
                _userInterface.setProjectsButton(new ProjectListForm(this, _mainForm.MainFormPanel));
            }
            return status;
        }

        //Add form to nevigation panel
        public void AddFormToNavigationPanel(Form form)
        {
            form.TopLevel = false;
            _navigationPanel.Controls.Add(form);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
            if (_navigationPanel.Controls.Count > 1)
            {
                Util.Animate(_navigationPanel.Controls[_navigationPanel.Controls.Count - 2], Util.Effect.Slide, 500, 180);
            }
        }

        //Add hierarchy button to userinterface
        public void AddFormButtonToUserInterface(Form form, string name, Image image)
        {
            if (_userInterface != null)
                _userInterface.AddFormButtonToBar(form, name, image);
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
            if (PopFormsFromPanel(_mainForm.LoginForm))
            {
                _model.SignOut();
                PopFormFromNavigationPanelAnimated();
            }
        }

        //Use animation to move the panel from navigationPanel to the right side
        public bool PopFormFromNavigationPanelAnimated()
        {
            if (_navigationPanel.Controls.Count > 1)
            {
                Util.Animate(_navigationPanel.Controls[_navigationPanel.Controls.Count - 2], Util.Effect.Slide, 500, 180);
                waitForAnimation(500);
                MethodInvoker mi = new MethodInvoker(this.PopFormFromNavigationPanel);
                var delay = Task.Delay(500).ContinueWith(_ =>
                {
                    _mainForm.BeginInvoke(mi, null);
                });
                return true;
            }
            return false;
        }

        //Remove form from navigationPanel
        public void PopFormFromNavigationPanel()
        {
            if (_navigationPanel.Controls.Count > 0)
            {
                _navigationPanel.Controls.RemoveAt(_navigationPanel.Controls.Count - 1);
            }
        }

        //Use animation to move the panel from mainFormPanel to the right side
        public bool PopFormsFromPanel(Control control)
        {
            if (isAnimating)
            {
                return false;
            }
            Control topControl = null;
            if (_mainFormPanel.Controls.Count > 0)
            {
                if (_mainFormPanel.Controls[_mainFormPanel.Controls.Count - 1] != control)
                    topControl = _mainFormPanel.Controls[_mainFormPanel.Controls.Count - 1];
                else
                    return false;
            }
            for (int i = _mainFormPanel.Controls.Count - 2; i >= 0; i--)
            {
                Control currentControl = _mainFormPanel.Controls[i];
                if (control == currentControl)
                {
                    break;
                }
                else
                    _mainFormPanel.Controls.RemoveAt(i);
            }
            if (_mainFormPanel.Controls.Count > 0)
            {
                Util.Animate(control, Util.Effect.Slide, 500, 180);
                waitForAnimation(500);
            }
            if (topControl != null)
            {
                MethodInvoker mi = new MethodInvoker(this.PopFormFromPanel);
                var delay = Task.Delay(500).ContinueWith(_ =>
                {
                    _mainForm.BeginInvoke(mi, null);
                });
            }
            return true;
        }

        //remove form from mainform
        public void PopFormFromPanel()
        {
            if (_mainFormPanel.Controls.Count > 0)
            {
                _mainFormPanel.Controls.RemoveAt(_mainFormPanel.Controls.Count - 1);
            }
        }

        //Get current form in mainFormPanel
        public Control GetCurrentFormInPanel()
        {
            if (_mainFormPanel.Controls.Count > 0)
            {
                Control control = _mainFormPanel.Controls[_mainFormPanel.Controls.Count - 1];
                return control;
            }
            return null;
        }

        // Get the form from mainFormPanel by type
        public Control GetFormByType(Type type)
        {
            foreach (Control control in _mainFormPanel.Controls)
            {
                if (control.GetType().Equals(type))
                {
                    return control;
                }
            }
            return null;
        }

        //Waiting time
        public void waitForAnimation(int waitingTime)
        {
            isAnimating = true;
            var delay = Task.Delay(waitingTime).ContinueWith(_ =>
            {
                isAnimating = false;
            });
        }

        public Bitmap ChangeColor(Bitmap scrBitmap, Color newColor)
        {
            Color actualColor;
            //make an empty bitmap the same size as scrBitmap
            Bitmap newBitmap = new Bitmap(scrBitmap.Width, scrBitmap.Height);
            for (int i = 0; i < scrBitmap.Width; i++)
            {
                for (int j = 0; j < scrBitmap.Height; j++)
                {
                    //get the pixel from the scrBitmap image
                    actualColor = scrBitmap.GetPixel(i, j);
                    // > 150 because.. Images edges can be of low pixel colr. if we set all pixel color to new then there will be no smoothness left.
                    if (actualColor.A > 150)
                        newBitmap.SetPixel(i, j, newColor);
                    else
                        newBitmap.SetPixel(i, j, actualColor);
                }
            }
            return newBitmap;
        }

        public async Task<HttpResponseMessage> GetUserListByProject(string projectId)
        {
            return await _model.GetUserListByProject(projectId);
        }

        public async Task<string> Registry(JObject jObject)
        {
            return await _model.Registry(jObject);
        }

        public async Task<HttpResponseMessage> GetRequirementByProject(string projectId)
        {
            return await _model.GetRequirementByProject(projectId);
        }

        public int GetUID()
        {
            return _model.UID;
        }

        public async Task<string> AddRequirement(JObject jObject)
        {
            return await _model.AddRequirement(jObject);
        }

        public async Task<string> AddProject(JObject jObject)
        {
            return await _model.AddProject(jObject);
        }

        public async Task<HttpResponseMessage> GetProjectList()
        {
            return await _model.GetProjectList();
        }

        public async Task<HttpResponseMessage> GetMethod(String method)
        {
            return await _model.GetMethod(method);
        }

        public async Task<HttpResponseMessage> AddUserToProject(JObject jObject)
        {
            return await _model.PostAddUserToProject(jObject);
        }
    }
}
