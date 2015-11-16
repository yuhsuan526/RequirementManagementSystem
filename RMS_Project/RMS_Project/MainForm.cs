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
        private UserInterfaceForm userInterface;
        private int accountId;
        private string username;
        public static string BASE_URL = "http://140.124.183.32:3000/";
        private bool isAnimating = false;
        private LoginForm loginForm;

        public enum Command { AddFormToPanel, PopFormsFromPanel };
        private Queue<PanelCommand> panelCommnadQueue;
        public class PanelCommand
        {
            public PanelCommand(Command command, Control control)
            {
                this.command = command;
                this.control = control;
            }
            public Command command;
            public Control control;
        }

        public MainForm()
        {
            InitializeComponent();
            loginForm = new LoginForm(this);
            AddFormToPanel(loginForm);
            AddFormToNavigationPanel(new DefaultInterfaceForm());
            panelCommnadQueue = new Queue<PanelCommand>();
        }

        public int UID
        {
            get
            {
                return accountId;
            }
        }

        public string Username
        {
            get
            {
                return username;
            }
        }

        public bool AddFormToPanel(Form form)
        {
            if (isAnimating)
            {
                //panelCommnadQueue.Enqueue(new PanelCommand(Command.AddFormToPanel, form));
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
            Console.WriteLine(mainFormPanel.Controls.Count);
            return false;
        }

        public void PopFormFromPanel()
        {
            if (mainFormPanel.Controls.Count > 0)
            {
                mainFormPanel.Controls.RemoveAt(mainFormPanel.Controls.Count - 1);
            }
        }

        public bool PopFormFromPanelAnimated()
        {
            if (isAnimating)
            {
                return false;
            }
            if (mainFormPanel.Controls.Count > 1)
            {
                Util.Animate(mainFormPanel.Controls[mainFormPanel.Controls.Count - 2], Util.Effect.Slide, 500, 180);
                waitForAnimation(500);
                MethodInvoker mi = new MethodInvoker(this.PopFormFromPanel);
                var delay = Task.Delay(500).ContinueWith(_ =>
                {
                    this.BeginInvoke(mi, null);
                });
                return true;
            }
            return false;
        }

        public bool PopFormsFromPanel(Control control)
        {
            if (isAnimating)
            {
                //panelCommnadQueue.Enqueue(new PanelCommand(Command.PopFormsFromPanel, control));
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
            Console.WriteLine(mainFormPanel.Controls.Count);
            return true;
        }


        public void waitForAnimation(int waitingTime)
        {
            isAnimating = true;
            //MethodInvoker mi = new MethodInvoker(this.DoCommand);
            var delay = Task.Delay(waitingTime).ContinueWith(_ =>
            {
                isAnimating = false;
                //this.BeginInvoke(mi, null);
            });
        }

        private void DoCommand()
        {
            if (panelCommnadQueue.Count > 0)
            {
                PanelCommand command = panelCommnadQueue.Dequeue();
                if (command != null)
                {
                    switch (command.command)
                    {
                        case Command.AddFormToPanel:
                            AddFormToPanel(command.control as Form);
                            break;
                        case Command.PopFormsFromPanel:
                            PopFormsFromPanel(command.control);
                            break;
                    }
                }
            }
        }

        public Control GetCurrentFormInPancel()
        {
            if (mainFormPanel.Controls.Count > 0)
            {
                Control control = mainFormPanel.Controls[mainFormPanel.Controls.Count - 1];
                return control;
            }
            return null;
        }

        public void AddFormToNavigationPanel(Form form)
        {
            form.TopLevel = false;
            navigationPanel.Controls.Add(form);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Width = navigationPanel.Width;
            form.Height = navigationPanel.Height;
            form.Show();
            Console.WriteLine(form.Location.ToString());
            if (navigationPanel.Controls.Count > 1)
            {
                Util.Animate(navigationPanel.Controls[navigationPanel.Controls.Count - 2], Util.Effect.Slide, 500, 180);
            }
        }

        public UserInterfaceForm GetUserInterface()
        {
            return userInterface;
        }

        public void AddFormButtonToUserInterface(Form form, string name, Image image)
        {
            if (this.userInterface != null)
                this.userInterface.AddFormButtonToBar(form, name, image);
        }

        public void PopFormFromNavigationPanel()
        {
            if (navigationPanel.Controls.Count > 0)
            {
                navigationPanel.Controls.RemoveAt(navigationPanel.Controls.Count - 1);
            }
        }

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

        public void SignIn(int uid, string name)
        {
            this.accountId = uid;
            this.username = name;
            UserInterfaceForm form = new UserInterfaceForm(this);
            AddFormToNavigationPanel(form);
            this.userInterface = form;
        }

        public void SignOut()
        {
            if (PopFormsFromPanel(loginForm))
            {
                this.accountId = -1;
                this.username = "";
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
