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
        public Model _model = new Model();

        private UserInterfaceForm userInterface;
        private bool isAnimating = false;
        private LoginForm loginForm;

        //Constructor
        public MainForm()
        {
            InitializeComponent();
            loginForm = new LoginForm(this);
            AddFormToPanel(loginForm);
            AddFormToNavigationPanel(new DefaultInterfaceForm());
        }

        //Add form to mainFormPanel
        public bool AddFormToPanel(Form form)
        {
            if (isAnimating)
            {
                return false;
            }
            form.TopLevel = false;
            mainFormPanel.Controls.Add(form);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
            if (mainFormPanel.Controls.Count > 1)
            {
                Util.Animate(mainFormPanel.Controls[mainFormPanel.Controls.Count - 2], Util.Effect.Slide, 500, 180);
                waitForAnimation(500);
                return true;
            }
            return false;
        }

        // Get the form from mainFormPanel by type
        public Control GetFormByType(Type type)
        {
            foreach(Control control in mainFormPanel.Controls)
            {
                if (control.GetType().Equals(type))
                {
                    return control;
                }
            }
            return null;
        }

        //remove form from mainform
        public void PopFormFromPanel()
        {
            if (mainFormPanel.Controls.Count > 0)
            {
                mainFormPanel.Controls.RemoveAt(mainFormPanel.Controls.Count - 1);
            }
        }
        
        //User animation to move the panel from mainFormPanel
        //public bool PopFormFromPanelAnimated()
        //{
        //    if (isAnimating)
        //    {
        //        return false;
        //    }
        //    if (mainFormPanel.Controls.Count > 1)
        //    {
        //        Util.Animate(mainFormPanel.Controls[mainFormPanel.Controls.Count - 2], Util.Effect.Slide, 500, 180);
        //        waitForAnimation(500);
        //        MethodInvoker mi = new MethodInvoker(this.PopFormFromPanel);
        //        var delay = Task.Delay(500).ContinueWith(_ =>
        //        {
        //            this.BeginInvoke(mi, null);
        //        });
        //        return true;
        //    }
        //    return false;
        //}

        //Use animation to move the panel from mainFormPanel to the right side
        public bool PopFormsFromPanel(Control control)
        {
            if (isAnimating)
            {
                return false;
            }
            Control topControl = null;
            if (mainFormPanel.Controls.Count > 0)
            {
                if (mainFormPanel.Controls[mainFormPanel.Controls.Count - 1] != control)
                    topControl = mainFormPanel.Controls[mainFormPanel.Controls.Count - 1];
                else
                    return false;
            }
            for (int i = mainFormPanel.Controls.Count - 2; i >= 0; i-- )
            {
                Control currentControl = mainFormPanel.Controls[i];
                if (control == currentControl)
                {
                    break;
                }
                else
                    mainFormPanel.Controls.RemoveAt(mainFormPanel.Controls.Count - 1);
            }
            if (mainFormPanel.Controls.Count > 0)
            {
                Util.Animate(control, Util.Effect.Slide, 500, 180);
                waitForAnimation(500);
            }
            if (topControl != null)
            {
                MethodInvoker mi = new MethodInvoker(this.PopFormFromPanel);
                var delay = Task.Delay(500).ContinueWith(_ =>
                {
                    this.BeginInvoke(mi, null);
                });
            }
            return true;
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

        //Get current form in mainFormPanel
        public Control GetCurrentFormInPanel()
        {
            if (mainFormPanel.Controls.Count > 0)
            {
                Control control = mainFormPanel.Controls[mainFormPanel.Controls.Count - 1];
                return control;
            }
            return null;
        }

        //Add form to nevigation panel
        public void AddFormToNavigationPanel(Form form)
        {
            form.TopLevel = false;
            navigationPanel.Controls.Add(form);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Width = navigationPanel.Width;
            form.Height = navigationPanel.Height;
            form.Show();
            if (navigationPanel.Controls.Count > 1)
            {
                Util.Animate(navigationPanel.Controls[navigationPanel.Controls.Count - 2], Util.Effect.Slide, 500, 180);
            }
        }

        public UserInterfaceForm GetUserInterface()
        {
            return userInterface;
        }

        //Add hierarchy button to userinterface
        public void AddFormButtonToUserInterface(Form form, string name, Image image)
        {
            if (this.userInterface != null)
                this.userInterface.AddFormButtonToBar(form, name, image);
        }

        //Remove form from navigationPanel
        public void PopFormFromNavigationPanel()
        {
            if (navigationPanel.Controls.Count > 0)
            {
                navigationPanel.Controls.RemoveAt(navigationPanel.Controls.Count - 1);
            }
        }

        //Use animation to move the panel from navigationPanel to the right side
        public bool PopFormFromNavigationPanelAnimated()
        {
            if (navigationPanel.Controls.Count > 1)
            {
                Util.Animate(navigationPanel.Controls[navigationPanel.Controls.Count - 2], Util.Effect.Slide, 500, 180);
                waitForAnimation(500);
                MethodInvoker mi = new MethodInvoker(this.PopFormFromNavigationPanel);
                var delay = Task.Delay(500).ContinueWith(_ =>
                {
                    this.BeginInvoke(mi, null);
                });
                return true;
            }
            return false;
        }

        public void SignIn()
        {
            UserInterfaceForm form = new UserInterfaceForm(this);
            AddFormToNavigationPanel(form);
            this.userInterface = form;
        }

        public void SignOut()
        {
            if (PopFormsFromPanel(loginForm))
            {
                _model.SignOut();
                PopFormFromNavigationPanelAnimated();
                this.userInterface = null;
            }
        }

        public static Bitmap ChangeColor(Bitmap scrBitmap, Color newColor)
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
    }
}
