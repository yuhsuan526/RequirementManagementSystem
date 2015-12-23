using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace RMS_Project
{
    public partial class RegistrantionForm : Form, FunctionalTypeInterface
    {
        private PresentationModel _presentationModel;
        public RegistrantionForm(PresentationModel presentationModel)
        {
            InitializeComponent();
            this._presentationModel = presentationModel;
        }

        private async void Register()
        {
            JObject jObject = new JObject();
            jObject["name"] = userName.Text;
            jObject["email"] = email.Text;
            jObject["password"] = password.Text;

            string status = await _presentationModel.Registry(jObject);
            if (status == "success")
            {
                _presentationModel.PopFormFromPanel();
                MessageBox.Show("註冊成功", "Success", MessageBoxButtons.OK);
            }
            else if (status == "註冊失敗")
            {
                MessageBox.Show("註冊失敗", "Error", MessageBoxButtons.OK);
            }
            else if (status == "伺服器無回應")
            {
                MessageBox.Show("伺服器無回應", "Error", MessageBoxButtons.OK);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            _presentationModel.PopFormFromPanel();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (password.Text.Equals(confirmPasswordTextBox.Text))
                Register();
            else
            {
                password.Text = "";
                confirmPasswordTextBox.Text = "";
                MessageBox.Show("密碼不一致，請在確認一次", "Error", MessageBoxButtons.OK);
            }
        }

        public UserInterfaceForm.FunctionalType GetFunctionalType()
        {
            return UserInterfaceForm.FunctionalType.None;
        }
    }
}
