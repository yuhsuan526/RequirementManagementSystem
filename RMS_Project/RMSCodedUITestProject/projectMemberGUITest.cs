
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using ezLogUITest;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using System.Timers;


namespace RMSCodedUITestProject
{
    /// <summary>
    /// projectMemberGUITest 的摘要描述
    /// </summary>
    [CodedUITest]
    public class projectMemberGUITest
    {
        private string FILE_PATH = "../../../RMS_Project/bin/debug/RMS_Project.exe";
        private string UI_TESTING_EXAMPLE_TITLE = "RMS_Project";
        private UITestControl _root;

        [TestInitialize()]
        public void Initialize()
        {
            _root = Robot.Initialize(FILE_PATH, UI_TESTING_EXAMPLE_TITLE);
        }

        [TestCleanup()]
        public void Cleanup()
        {
            Robot.CleanUp();
        }

        [TestMethod]
        [DeploymentItem("RMS_Project.exe")]
        public void CheckMemberData()
        {

            //設定帳密
            Robot.SetOtherFormEdit("loginForm", "emailLabel", "j00064qaz123@gmail.com");
            Robot.SetOtherFormUseSystemPasswordChar("loginForm", "passwordLabel", "a123456");

            //確認登入資料
            Robot.AssertOtherFormEdit("loginForm", "emailLabel", "j00064qaz123@gmail.com");
            Robot.ClickOtherFormButton("loginForm", "signInButton");

            Robot.ClickDataGridView("projectListForm", "projectDataGridView", 0, 0,550,3);

            Robot.AssertWindowExist("ProjectMainForm", true);
            //確認 member資料是否正確
            Robot.ClickOtherFormButton("ProjectMainForm", "memberButton");
            Robot.AssertWindowExist("UserListForm", true);
            Robot.AssertDataGridViewNumericUpDownCellValue("UserListForm", "memberDataGridView", 0, 0, "ZZ");
        }


        [TestMethod]
        [DeploymentItem("RMS_Project.exe")]
        public void AddMemberData()
        {
            //設定帳密
            Robot.SetOtherFormEdit("loginForm", "emailLabel", "j00064qaz123@gmail.com");
            Robot.SetOtherFormUseSystemPasswordChar("loginForm", "passwordLabel", "a123456");

            //確認登入資料
            Robot.AssertOtherFormEdit("loginForm", "emailLabel", "j00064qaz123@gmail.com");
            Robot.ClickOtherFormButton("loginForm", "signInButton");

            Robot.ClickDataGridView("projectListForm", "projectDataGridView", 0, 0,550,3);


            Robot.AssertWindowExist("ProjectMainForm", true);
            //確認 member資料是否正確
            Robot.ClickOtherFormButton("ProjectMainForm", "memberButton");
            

            Robot.SetOtherFormEdit("userListForm", "userName", "user@user");
            Robot.ClickOtherFormComboBox("userListForm", "priorityComboBox", "Member");
            Robot.ClickOtherFormButton("UserInterfaceForm", "NewProjectButton");
            Robot.AssertWindowExist("Success", true);
            Robot.ClickOtherFormButton("Success", "確定");
            Robot.AssertDataGridViewNumericUpDownCellValue("UserListForm", "memberDataGridView", 0, 0, "ZZ");
            Robot.AssertDataGridViewNumericUpDownCellValue("UserListForm", "memberDataGridView", 1, 0, "YH");
        }

        
    }
}

