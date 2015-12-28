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
    /// RequirementGUITest 的摘要描述
    /// </summary>
    [CodedUITest]
    public class RequirementGUITest
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
        public void AddRequirementData()
        {
            //設定帳密
            Robot.SetOtherFormEdit("loginForm", "emailLabel", "j00064qaz123@gmail.com");
            Robot.SetOtherFormUseSystemPasswordChar("loginForm", "passwordLabel", "a123456");

            //確認登入資料
            Robot.AssertOtherFormEdit("loginForm", "emailLabel", "j00064qaz123@gmail.com");
            Robot.ClickOtherFormButton("loginForm", "signInButton");

            Robot.ClickDataGridView("projectListForm", "projectDataGridView", 0, 0);

            //Robot.ClickOtherFormButton("MainForm", "requirementButton");

            Robot.ClickOtherFormButton("projectMainForm", "requirementButton");


            Robot.ClickOtherFormButton("UserInterfaceForm", "NewProjectButton");

            Robot.SetOtherFormEdit("requirementEditorForm", "requirementName", "RMS");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "typeComboBox", "functional");
            Robot.SetOtherFormEdit("requirementEditorForm", "versionLabel", "1.0");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "priorityComboBox", "Medium");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "statusComboBox", "under review");
            Robot.SetOtherFormEdit("requirementEditorForm", "descriptionLabel", "Test");
            Robot.SetOtherFormEdit("requirementEditorForm", "memoLabel", "Test");
            Robot.ClickOtherFormButton("requirementEditorForm", "confirmButton");

            Robot.AssertWindowExist("Success", true);
            Robot.ClickOtherFormButton("Success", "確定");
        }
    }
}
