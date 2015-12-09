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
    public partial class BasicForm : Form
    {
        private Panel _parentPanel;
        private bool _isAnimating;

        public BasicForm() : base()
        {
            InitializeComponent();
        }

        public BasicForm(Panel parentPanel) : base()
        {
            _parentPanel = parentPanel;
            _isAnimating = false;
        }

        public bool AddForm(Form form)
        {
            if (_isAnimating)
            {
                return false;
            }
            form.TopLevel = false;
            _parentPanel.Controls.Add(form);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
            if (_parentPanel.Controls.Count > 1)
            {
                Util.Animate(_parentPanel.Controls[_parentPanel.Controls.Count - 2], Util.Effect.Slide, 500, 180);
                waitForAnimation(500);
                return true;
            }
            return false;
        }

        //Use animation to move the panel from mainFormPanel to the right side
        public bool PopForms(Control control)
        {
            if (_isAnimating)
            {
                return false;
            }
            Control topControl = null;
            if (_parentPanel.Controls.Count > 0)
            {
                if (_parentPanel.Controls[_parentPanel.Controls.Count - 1] != control)
                    topControl = _parentPanel.Controls[_parentPanel.Controls.Count - 1];
                else
                    return false;
            }
            for (int i = _parentPanel.Controls.Count - 2; i >= 0; i--)
            {
                Control currentControl = _parentPanel.Controls[i];
                if (control == currentControl)
                {
                    break;
                }
                else
                    _parentPanel.Controls.RemoveAt(_parentPanel.Controls.Count - 1);
            }
            if (_parentPanel.Controls.Count > 0)
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

        //remove form from mainform
        public void PopFormFromPanel()
        {
            if (_parentPanel.Controls.Count > 0)
            {
                _parentPanel.Controls.RemoveAt(_parentPanel.Controls.Count - 1);
            }
        }

        public void waitForAnimation(int waitingTime)
        {
            _isAnimating = true;
            var delay = Task.Delay(waitingTime).ContinueWith(_ =>
            {
                _isAnimating = false;
            });
        }
    }
}
