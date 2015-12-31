using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS_Project
{
    public partial class TestDetailForm : Form, FunctionalTypeInterface
    {
        private PresentationModel _presentationModel;
        private ArrayList _arrayList;
        private Test _test;
        private UserInterfaceForm.FunctionalType type;
        private bool isFinished;
        private JObject testJObject;
        private JArray rIdListJArray;

        public TestDetailForm(PresentationModel presentationModel,Test test)
        {
            InitializeComponent();
            _presentationModel = presentationModel;
            _test = test;
            _arrayList = new ArrayList();
            type = UserInterfaceForm.FunctionalType.Hide;
            RefreshTestDetail(test);
            CheckPriority();
        }

        public void RefreshTestDetail(Test test)
        {  
            _test = test;
            isFinished = false;
            _finishButton.Enabled = false;         
            GetTestCaseDetailInformation();
            GetRequirementByTestCaseId();
        }

        public async void GetTestCaseDetailInformation()
        {
            HttpResponseMessage response = await _presentationModel.GetTestCaseDetailInformationByTestCaseId(_test.ID);
            string content = await response.Content.ReadAsStringAsync();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                JObject json = JObject.Parse(content);

                //Console.WriteLine(json.ToString());

                string message = json["result"].ToString();
                JObject jsonObject = JObject.Parse(json["test_case"].ToString());
                if (message == "success")
                {
                    nameLabel.Text = jsonObject["name"].ToString();
                    idLabel.Text = jsonObject["id"].ToString();
                    JObject temp = JObject.Parse(jsonObject["owner"].ToString());
                    string owner = temp["name"].ToString();
                    ownerLabel.Text = owner;
                    JObject jHandler = JObject.Parse(jsonObject["asigned_as"].ToString());
                    string handler = jHandler["name"].ToString();
                    handlerLabel.Text = handler;
                    inputDataLabel.Text = jsonObject["input_data"].ToString();
                    expectedResultLabel.Text = jsonObject["expected_result"].ToString();
                    descriptionTextBox.Text = jsonObject["description"].ToString();
                    if (Int32.Parse(jHandler["id"].ToString()) == _presentationModel.GetUID())
                    {
                        _finishButton.Enabled = true;
                    }
                    else
                    {
                        _finishButton.Enabled = false;
                    }
                    if (jsonObject["finished"].ToString() != "False" )
                    {
                        _finishButton.Image = Properties.Resources.ios7_checkmark_outline;
                        _finishButton.Text = "Finished";
                        isFinished = true;
                    }
                    else
                    {
                        _finishButton.Image = Properties.Resources.ios7_circle_outline;
                        _finishButton.Text = "Unfinished";
                        isFinished = false; ;
                    }
                    testJObject = jsonObject;
                }
            }
            else if (response.StatusCode == HttpStatusCode.RequestTimeout)
            {
                MessageBox.Show("伺服器無回應", "Error", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("伺服器錯誤", "Error", MessageBoxButtons.OK);
            }
        }

        public async void GetRequirementByTestCaseId()
        {
            HttpResponseMessage response = await _presentationModel.GetRequirementByTestCaseId(_test.ID);
            string content = await response.Content.ReadAsStringAsync();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                JObject json = JObject.Parse(content);
                string message = json["result"].ToString();
                JArray jsonArray = JArray.Parse(json["requirements"].ToString());
                rIdListJArray = jsonArray;
                if (message == "success")
                {
                    this._requirementListDataGridView.Rows.Clear();
                    foreach (JObject jObject in jsonArray)
                    {
                        this._requirementListDataGridView.Rows.Add(jObject["name"]);
                        JObject jOwner = jObject["owner"] as JObject;
                        JObject jHandler = jObject["handler"] as JObject;
                        JObject jType = jObject["requirement_type"] as JObject;
                        JObject jPriority = jObject["priority_type"] as JObject;
                        JObject jStatus = jObject["status_type"] as JObject;
                        User owner = _presentationModel.getUser((int)jOwner["id"], jOwner["name"].ToString());
                        User handler = _presentationModel.getUser((int)jHandler["id"], jHandler["name"].ToString());
                        NormalAttribute type = _presentationModel.getRequirementAttribute((int)jType["id"], jType["name"].ToString());
                        NormalAttribute priority = _presentationModel.getRequirementAttribute((int)jPriority["id"], jPriority["name"].ToString());
                        NormalAttribute status = _presentationModel.getRequirementAttribute((int)jStatus["id"], jStatus["name"].ToString());
                        Requirement requirement = new Requirement((int)jObject["id"], int.Parse(jObject["project_id"].ToString()), jObject["name"].ToString(), owner, handler,
                            jObject["description"].ToString(), jObject["version"].ToString(), jObject["memo"].ToString(),
                            type, priority, status);
                        _arrayList.Add(requirement);
                    }
                }
            }
            else if (response.StatusCode == HttpStatusCode.RequestTimeout)
            {
                MessageBox.Show("伺服器無回應", "Error", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("伺服器錯誤", "Error", MessageBoxButtons.OK);
            }
        }

        public Test Test
        {
            get
            {
                return _test;
            }
        }

        public UserInterfaceForm.FunctionalType GetFunctionalType()
        {
            return type;
        }

        private async void CheckPriority()
        {
            JObject jObject = await _presentationModel.GetPriority(_test.ProjectID);
            if (jObject["priority_type_name"].ToString().Equals("Owner") ||
                jObject["priority_type_name"].ToString().Equals("Manager"))
            {
                type = UserInterfaceForm.FunctionalType.Edit;
                _presentationModel.SetFunctionalButton(type);
            }
        }

        private void _finishButton_MouseLeave(object sender, EventArgs e)
        {
            _finishButton.ForeColor = Color.Black;
            _finishButton.Image = _presentationModel.ChangeColor(new Bitmap(_finishButton.Image), Color.Black);
        }

        private void _finishButton_MouseMove(object sender, MouseEventArgs e)
        {
            _finishButton.ForeColor = Color.CornflowerBlue;
            _finishButton.Image = _presentationModel.ChangeColor(new Bitmap(_finishButton.Image), Color.CornflowerBlue);
        }

        private void _finishButton_Click(object sender, EventArgs e)
        {
            EditTestCase();
        }

        async void EditTestCase()
        {
            JObject jObject = new JObject();
            jObject["id"] = testJObject["id"].ToString();
            jObject["pid"] = _test.ProjectID;
            jObject["name"] = testJObject["name"].ToString();
            jObject["description"] = testJObject["description"].ToString();
            JObject tempOwner = JObject.Parse(testJObject["owner"].ToString());
            string owner = tempOwner["id"].ToString();
            jObject["owner"] = owner;
            JObject jHandler = JObject.Parse(testJObject["asigned_as"].ToString());
            jObject["asigned_as"] = jHandler["id"].ToString();
            jObject["input_data"] = testJObject["input_data"].ToString();
            jObject["expected_result"] = testJObject["expected_result"].ToString();
            string temp = "";
            foreach (JObject rIdObject in rIdListJArray)
            {
                int rid = Int32.Parse(rIdObject["id"].ToString());
                temp += rid;
                temp += ",";
            }
            if (temp != "")
                temp = temp.Substring(0, temp.Length - 1);
            jObject["rid_list"] = temp;
            isFinished = !isFinished;
            if (isFinished)
            {
                jObject["finished"] = 1;
            }
            else
            {
                jObject["finished"] = 0;
            }

            string status = await _presentationModel.EditTestCase(jObject);
            if (status == "success")
            {
                RefreshTestDetail(_test);
                MessageBox.Show("測試案例修改成功", "Success", MessageBoxButtons.OK);
            }
            else if (status == "測試案例修改失敗")
            {
                MessageBox.Show("測試案例修改失敗", "Error", MessageBoxButtons.OK);
            }
            else if (status == "伺服器無回應")
            {
                MessageBox.Show("測試案例伺服器無回應", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
