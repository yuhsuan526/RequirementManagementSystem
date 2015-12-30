using System;
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
    /// TestGUITest 的摘要描述
    /// </summary>
    [CodedUITest]
    public class TestGUITest
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
        public void NewTestCoded()
        {
            Robot.SetOtherFormEdit("loginForm", "emailLabel", "j00064qaz123@gmail.com");

            Robot.SetOtherFormUseSystemPasswordChar("loginForm", "passwordLabel", "a123456");

            Robot.AssertOtherFormEdit("loginForm", "emailLabel", "j00064qaz123@gmail.com");
            Robot.ClickOtherFormButton("loginForm", "signInButton");
            Robot.AssertWindowExist("projectListForm", true);

            Robot.ClickDataGridView("projectListForm", "projectDataGridView", 0, 0, 550, 3);
            Robot.AssertWindowExist("ProjectMainForm", true);

            Robot.ClickOtherFormButton("ProjectMainForm", "testButton");

            Robot.AssertWindowExist("testListForm", true);

            Robot.ClickOtherFormButton("UserInterfaceForm", "NewProjectButton");

            Robot.SetOtherFormEdit("testEditorForm", "testName", "login test");
            Robot.SetOtherFormEdit("testEditorForm", "testInputData", "test2@test/123456");
            Robot.SetOtherFormEdit("testEditorForm", "testResult", "success");
            Robot.ClickOtherFormComboBox("testEditorForm", "ownerCombobox", "ZZ");
            Robot.SetOtherFormEdit("testEditorForm", "testDescription", "Test login account and password is true");
            Robot.CheckTheCheckedListBox("testEditorForm","checkedListBox",0,true);
            Robot.ClickOtherFormButton("testEditorForm", "testConfirm");

            Robot.AssertWindowExist("Success", true);
            Robot.ClickOtherFormButton("Success", "確定");

            Robot.AssertDataGridViewNumericUpDownCellValue("testListForm", "testListDataGridView", 0, 0, "login test");
            //Robot.SetCheckBox("testEditorForm", "checkedListBox");
        }

        [TestMethod]
        [DeploymentItem("RMS_Project.exe")]
        public void EditTestCoded()
        {
            Robot.SetOtherFormEdit("loginForm", "emailLabel", "j00064qaz123@gmail.com");

            Robot.SetOtherFormUseSystemPasswordChar("loginForm", "passwordLabel", "a123456");

            Robot.AssertOtherFormEdit("loginForm", "emailLabel", "j00064qaz123@gmail.com");
            Robot.ClickOtherFormButton("loginForm", "signInButton");
            Robot.AssertWindowExist("projectListForm", true);

            Robot.ClickDataGridView("projectListForm", "projectDataGridView", 0, 0, 550, 3);
            Robot.AssertWindowExist("ProjectMainForm", true);

            Robot.ClickOtherFormButton("ProjectMainForm", "testButton");

            Robot.AssertWindowExist("testListForm", true);

            Robot.ClickDataGridView("testListForm", "testListDataGridView", 0, 0, 300, 3);

            Robot.AssertWindowExist("testDetailForm", true);

            Robot.ClickOtherFormButton("UserInterfaceForm", "NewProjectButton");

            Robot.SetOtherFormEdit("testEditorForm", "testName", "login_test");
            Robot.SetOtherFormEdit("testEditorForm", "testInputData", "account:test2@test/password:123456");
            Robot.SetOtherFormEdit("testEditorForm", "testResult", "success");
            Robot.ClickOtherFormComboBox("testEditorForm", "ownerCombobox", "YH");
            Robot.SetOtherFormEdit("testEditorForm", "testDescription", "Test login account and password is true");
            Robot.CheckTheCheckedListBox("testEditorForm", "checkedListBox", 0, true);
            Robot.ClickOtherFormButton("testEditorForm", "testConfirm");

            Robot.AssertWindowExist("Success", true);
            Robot.ClickOtherFormButton("Success", "確定");

            Robot.AssertWindowExist("testDetailForm", true);

            Robot.AssertOtherText("testDetailForm", "idLabel", "16");
            Robot.AssertOtherText("testDetailForm", "nameLabel", "login_test");
            Robot.AssertOtherText("testDetailForm", "inputDataLabel", "account:test2@test/password:123456");
            Robot.AssertOtherText("testDetailForm", "expectedResultLabel", "success");
            Robot.AssertOtherText("testDetailForm", "ownerLabel", "ZZ");
            Robot.AssertOtherText("testDetailForm", "handlerLabel", "YH");

            Robot.AssertDataGridViewNumericUpDownCellValue("testDetailForm", "testDataGridView", 0, 0, "The system shall provide a project management mechanism.");
        }
    }
}
