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
    /// TestGUITestDeleteRquirment 的摘要描述
    /// </summary>
    [CodedUITest]
    public class TestGUITestDeleteRquirment
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
        public void CheckDeleteRequirement()
        {
            Robot.SetOtherFormEdit("loginForm", "emailLabel", "j00064qaz123@gmail.com");

            Robot.SetOtherFormUseSystemPasswordChar("loginForm", "passwordLabel", "a123456");

            Robot.AssertOtherFormEdit("loginForm", "emailLabel", "j00064qaz123@gmail.com");
            Robot.ClickOtherFormButton("loginForm", "signInButton");
            Robot.AssertWindowExist("projectListForm", true);

            Robot.ClickDataGridView("projectListForm", "projectDataGridView", 0, 0, 550, 3);
            Robot.AssertWindowExist("ProjectMainForm", true);

            Robot.ClickOtherFormButton("projectMainForm", "requirementButton");

            Robot.AssertWindowExist("requirementListForm", true);

            Robot.ClickOtherFormButton("UserInterfaceForm", "NewProjectButton");

            Robot.SetOtherFormEdit("requirementEditorForm", "requirementName", "The system shall provide a requirement collection mechanism for a given project.");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "typeComboBox", "functional");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "priorityComboBox", "High");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "statusComboBox", "Open");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "handlerComboBox", "YH");
            Robot.SetOtherFormEdit("requirementEditorForm", "descriptionLabel", "The system shall allow to create/edit/delete a requirement that can be described in terms of feature list or use case or user story.");
            Robot.SetOtherFormEdit("requirementEditorForm", "memoLabel", "2.1Each requirement shall have attributes, such as ID, name, type (e.g., functional or non-functional), description, version, priority, status, owner, memo, handler, attachment file.\n2.2For use case type of requirement, the requirement shall have additional attributes, such as goal, precondition, postcondition, main flow, and alternative flow.");
            Robot.ClickOtherFormButton("requirementEditorForm", "confirmButton");
            Robot.AssertWindowExist("Success", true);
            Robot.ClickOtherFormButton("Success", "確定");

            Robot.ClickDataGridView("requirementListForm", "requirementListDataGridView", 0, 3, 10, 3);
            Robot.AssertWindowExist("Success", true);
            Robot.ClickOtherFormButton("Success", "確定");

            Robot.AssertDataGridViewNumericUpDownCellValue("requirementListForm", "requirementListDataGridView", 0, 0, "The system shall provide a requirement collection mechanism for a given project.");
        }

        [TestMethod]
        [DeploymentItem("RMS_Project.exe")]
        public void CheckTestDetail()
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
        }
    }
}
