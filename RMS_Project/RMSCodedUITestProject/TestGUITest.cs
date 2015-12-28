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

        /*[TestMethod]
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




            //Robot.SetCheckBox("testEditorForm", "checkedListBox");
        }*/
    }
}
