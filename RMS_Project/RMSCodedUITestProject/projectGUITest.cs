
﻿using System;
﻿using System;
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
    /// projectGUITest 的摘要描述
    /// </summary>
    [CodedUITest]
    public class projectGUITest
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
        public void NewProjectCoded()
        {
            //設定帳密
            Robot.SetOtherFormEdit("loginForm", "emailLabel", "j00064qaz123@gmail.com");
            Robot.SetOtherFormUseSystemPasswordChar("loginForm", "passwordLabel", "a123456");

            //確認登入資料
            Robot.AssertOtherFormEdit("loginForm", "emailLabel", "j00064qaz123@gmail.com");
            Robot.ClickOtherFormButton("loginForm", "signInButton");
            Robot.AssertWindowExist("projectListForm", true);

            //新增專案
            Robot.ClickOtherFormButton("UserInterfaceForm", "NewProjectButton");
            Robot.SetOtherFormEdit("ProjectEditorForm", "ProjectName", "RMS_Project");
            Robot.SetOtherFormEdit("ProjectEditorForm", "ProjectDescription", "This project aims to develop a system that facilitates the management of project requirements.");

            //確認專案內容
            Robot.AssertOtherFormEdit("ProjectEditorForm", "ProjectName", "RMS_Project");

            Robot.ClickOtherFormButton("ProjectEditorForm", "Confirm");

            //messageBox成功
            Robot.AssertWindowExist("Success", true);
            Robot.ClickOtherFormButton("Success", "確定");
            Robot.AssertWindowExist("projectListForm", true);

        }

        [TestMethod]
        [DeploymentItem("RMS_Project.exe")]
        public void CheckDataListData()
        {

            //設定帳密
            Robot.SetOtherFormEdit("loginForm", "emailLabel", "j00064qaz123@gmail.com");
            Robot.SetOtherFormUseSystemPasswordChar("loginForm", "passwordLabel", "a123456");

            //確認登入資料
            Robot.AssertOtherFormEdit("loginForm", "emailLabel", "j00064qaz123@gmail.com");
            Robot.ClickOtherFormButton("loginForm", "signInButton");
            Robot.AssertWindowExist("projectListForm", true);
            //Robot.AssertDataGridViewNumericUpDownCellValue("projectListForm", "projectDataGridView", 0, 0, "ZZ");
            Robot.AssertDataGridViewNumericUpDownCellValue("projectListForm", "projectDataGridView", 0, 0, "RMS_Project");
        }

        [TestMethod]
        [DeploymentItem("RMS_Project.exe")]
        public void CheckProjectDetailFormDataGridView()
        {
            //設定帳密
            Robot.SetOtherFormEdit("loginForm", "emailLabel", "j00064qaz123@gmail.com");
            Robot.SetOtherFormUseSystemPasswordChar("loginForm", "passwordLabel", "a123456");

            //確認登入資料
            Robot.AssertOtherFormEdit("loginForm", "emailLabel", "j00064qaz123@gmail.com");
            Robot.ClickOtherFormButton("loginForm", "signInButton");
            Robot.AssertWindowExist("projectListForm", true);

            Robot.ClickDataGridView("projectListForm", "projectDataGridView", 0, 0);
            Robot.AssertWindowExist("ProjectMainForm", true);

            //確認Detail資料顯示是否正確
            Robot.AssertOtherText("ProjectMainForm", "projectName", "RMS_Project");
           // Robot.AssertOtherText("projectDetailForm", "projectDescription", "AAA");
        }
    }
}

