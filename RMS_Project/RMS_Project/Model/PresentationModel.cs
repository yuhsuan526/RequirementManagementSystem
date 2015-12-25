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
                if (_userInterface != null)
                    _userInterface.SetFunctionalButton(((FunctionalTypeInterface)form).GetFunctionalType());
                return true;
            }
            return true;
        }

        public async Task<string> SignIn(JObject jObject)
        {
            string status = await _model.SignIn(jObject);
            if (status == "success")
            {
                UserInterfaceForm form = new UserInterfaceForm(this);
                AddFormToNavigationPanel(form);
                _userInterface = form;
                _userInterface.setProjectsButton(new ProjectListForm(this));
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
                MethodInvoker mi = new MethodInvoker(this.PopForm);
                var delay = Task.Delay(500).ContinueWith(_ =>
                {
                    _mainForm.BeginInvoke(mi, null);
                });
            }
            if (_userInterface != null)
                _userInterface.SetFunctionalButton(((FunctionalTypeInterface)control).GetFunctionalType());
            return true;
        }

        private void PopForm()
        {
            if (_mainFormPanel.Controls.Count > 0)
            {
                _mainFormPanel.Controls.RemoveAt(_mainFormPanel.Controls.Count - 1);
            }
        }

        //Remove top form from mainform
        public bool PopFormFromPanel()
        {
            if (isAnimating)
            {
                return false;
            }
            Control topControl = null;
            Control targetControl = null;
            if (_mainFormPanel.Controls.Count > 0)
            {
                topControl = _mainFormPanel.Controls[_mainFormPanel.Controls.Count - 1];
            }
            else
            {
                return false;
            }
            if (_mainFormPanel.Controls.Count > 1)
            {
                targetControl = _mainFormPanel.Controls[_mainFormPanel.Controls.Count - 2];
                Util.Animate(targetControl, Util.Effect.Slide, 500, 180);
                waitForAnimation(500);
            }
            if (topControl != null)
            {
                MethodInvoker mi = new MethodInvoker(this.PopForm);
                var delay = Task.Delay(500).ContinueWith(_ =>
                {
                    _mainForm.BeginInvoke(mi, null);
                });
            }
            if (_userInterface != null && targetControl != null)
                _userInterface.SetFunctionalButton(((FunctionalTypeInterface)targetControl).GetFunctionalType());
            return true;
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

        public async Task<NormalAttribute[]> GetProjectPriorityType()
        {
            return await _model.GetProjectPriorityType();
        }

        public async Task<string> DeleteUserFromProject(int projectId, int userId)
        {
            return await _model.DeleteUserFromProject(projectId, userId);
        }

        public async Task<string> AddRequirement(JObject jObject)
        {
            return await _model.AddRequirement(jObject);
        }

        public async Task<string> AddProject(JObject jObject)
        {
            return await _model.AddProject(jObject);
        }

        public async Task<string> EditProject(Project project)
        {
            return await _model.EditProject(project);
        }

        public async Task<string> DeleteProject(int projectId)
        {
            return await _model.DeleteProject(projectId);
        }

        public async Task<Project[]> GetManagedProjectListByUserId()
        {
            return await _model.GetManagedProjectListByUserId();
        }

        public async Task<Project[]> GetOwnedProjectListByUserId()
        {
            return await _model.GetOwnedProjectListByUserId();
        }

        public async Task<HttpResponseMessage> GetProjectList()
        {
            return await _model.GetProjectList();
        }

        public async Task<HttpResponseMessage> GetRequirementMethod(String method)
        {
            return await _model.GetRequirementMethod(method);
        }

        public async Task<HttpResponseMessage> AddUserToProject(JObject jObject)
        {
            return await _model.AddUserToProject(jObject);
        }

        public async Task<string> EditRequirement(Requirement requirement)
        {
            return await _model.EditRequirement(requirement);
        }

        public async Task<string> DeleteRequirement(int RequirementId)
        {
            return await _model.DeleteRequirement(RequirementId);
        }

        public async Task<string> EditTestCase(Test test)
        {
            return await _model.EditTestCase(test);
        }

        public async Task<string> DeleteTestCase(int tsetId)
        {
            return await _model.DeleteTestCase(tsetId);
        }

        public async Task<string> AddTestCase(JObject jObject)
        {
            return await _model.AddTestCase(jObject);
        }

        public async Task<HttpResponseMessage> GetTestCaseListByRequirementId(int requirementId)
        {
            return await _model.GetTestCaseListByRequirementId(requirementId);
        }

        public async Task<HttpResponseMessage> GetTestCaseListByProjectId(int projectId)
        {
            return await _model.GetTestCaseListByProjectId(projectId);
        }

        public async Task<JArray> GetRequirementToRequirementRelationByProjectId(int projectId)
        {
            return await _model.GetRequirementToRequirementRelationByProjectId(projectId);
        }

        public async Task<string> CreateRequirementToRequirementRelation(JObject jObject)
        {
            return await _model.CreateRequirementToRequirementRelation(jObject);
        }

        public async Task<string> DeleteRequirementToRequirementRelationByProject(int projectId)
        {
            return await _model.DeleteRequirementToRequirementRelationByProject(projectId);
        }

        public void ClickFunctionalButton()
        {
            Control control = GetCurrentFormInPanel();
            if (control.GetType().Equals(typeof(ProjectListForm)))
            {
                ProjectEditorForm form = new ProjectEditorForm(this);
                AddFormToPanel(form);
            }
            else if (control.GetType().Equals(typeof(ProjectMainForm)))
            {
                ProjectMainForm form = control as ProjectMainForm;
                AddFormToPanel(new ProjectEditorForm(this, form.Project));
            }
            else if (control.GetType().Equals(typeof(RequirementListForm)))
            {
                RequirementListForm form = control as RequirementListForm;
                RequirementEditorForm requirementEditorForm = new RequirementEditorForm(this, form.Project);
                AddFormToPanel(requirementEditorForm);
            }
            else if (control.GetType().Equals(typeof(TestListForm)))
            {
                TestListForm form = control as TestListForm;
                TestEditorForm requirementEditorForm = new TestEditorForm(this, form.Project);
                AddFormToPanel(requirementEditorForm);
            }
            else if (control.GetType().Equals(typeof(RequirementDetailForm)))
            {
                RequirementDetailForm form = control as RequirementDetailForm;
                RequirementEditorForm requirementEditorForm = new RequirementEditorForm(this, form.Requirement);
                AddFormToPanel(requirementEditorForm);
            }
            else if (control.GetType().Equals(typeof(TestDetailForm)))
            {
                TestDetailForm form = control as TestDetailForm;
                TestEditorForm requirementEditorForm = new TestEditorForm(this, form.Test);
                AddFormToPanel(requirementEditorForm);
            }
            else if (control.GetType().Equals(typeof(OthersForm)))
            {
                OthersForm form = control as OthersForm;
                form.AddRelation();
            }
            else if (control.GetType().Equals(typeof(UserListForm)))
            {
                UserListForm form = control as UserListForm;
                form.AddUser();
            }
        }

        public User getUser(int id, string name)
        {
            User user = new User();
            user.ID = id;
            user.Name = name;
            return user;
        }

        public NormalAttribute getRequirementAttribute(int id, string name)
        {
            NormalAttribute attribute = new NormalAttribute();
            attribute.ID = id;
            attribute.Name = name;
            return attribute;
        }
    }
}
