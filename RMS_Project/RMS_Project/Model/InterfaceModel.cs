using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS_Project
{
    public class InterfaceModel
    {
        private BasicForm _form;
        private PictureBox _arrow;
        private Button _button;

        public BasicForm Form
        {
            set
            {
                _form = value;
            }
            get
            {
                return _form;
            }
        }

        public PictureBox PictureBox
        {
            set
            {
                _arrow = value;
            }
            get
            {
                return _arrow;
            }
        }

        public Button Button
        {
            set
            {
                _button = value;
            }
            get
            {
                return _button;
            }
        }
    }
}
