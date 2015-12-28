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

            Robot.ClickDataGridView("projectListForm", "projectDataGridView", 0, 0,550,3);


            Robot.ClickOtherFormDoubleButton("projectMainForm", "requirementButton");

            Robot.AssertWindowExist("requirementListForm", true);

            Robot.ClickOtherFormButton("UserInterfaceForm", "NewProjectButton");

            Robot.SetOtherFormEdit("requirementEditorForm", "requirementName", "The system shall provide a project management mechanism.");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "typeComboBox", "functional");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "priorityComboBox", "High");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "statusComboBox", "Open");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "handlerComboBox", "ZZ");
            Robot.SetOtherFormEdit("requirementEditorForm", "descriptionLabel", "The system shall provide a mechanism that allows to manage project.");
            Robot.SetOtherFormEdit("requirementEditorForm", "memoLabel", "none");
            Robot.ClickOtherFormButton("requirementEditorForm", "confirmButton");
            Robot.AssertWindowExist("Success", true);
            Robot.ClickOtherFormButton("Success", "確定");
            Robot.AssertDataGridViewNumericUpDownCellValue("requirementListForm", "requirementListDataGridView", 0, 0, "The system shall provide a project management mechanism.");
        }


        [TestMethod]
        [DeploymentItem("RMS_Project.exe")]
        public void AddRequirementComment() 
        {
            //設定帳密
            Robot.SetOtherFormEdit("loginForm", "emailLabel", "j00064qaz123@gmail.com");
            Robot.SetOtherFormUseSystemPasswordChar("loginForm", "passwordLabel", "a123456");

            //確認登入資料
            Robot.AssertOtherFormEdit("loginForm", "emailLabel", "j00064qaz123@gmail.com");
            Robot.ClickOtherFormButton("loginForm", "signInButton");

            Robot.ClickDataGridView("projectListForm", "projectDataGridView", 0, 0, 550, 3);


            Robot.ClickOtherFormDoubleButton("projectMainForm", "requirementButton");

            Robot.AssertWindowExist("requirementListForm", true);
            Robot.ClickDataGridView("requirementListForm", "requirementListDataGridView", 0, 2, 20, 3);

            Robot.SetOtherFormEdit("commentEditorForm", "commentRichTextBox", "Good!");
            Robot.SetOtherFormEdit("commentEditorForm", "decisionRichTextBox", "None");

            Robot.ClickOtherFormButton("commentEditorForm", "confirmButton");
            Robot.AssertWindowExist("Success", true);
            Robot.ClickOtherFormButton("Success", "確定");
            Robot.ClickDataGridView("requirementListForm", "requirementListDataGridView", 0, 0, 300, 3);
            Robot.AssertDataGridViewNumericUpDownCellValue("requirementDetailForm", "commentDataGridView", 0, 0, "ZZ");
            Robot.AssertDataGridViewNumericUpDownCellValue("requirementDetailForm", "commentDataGridView", 0, 1, "Good!");
            Robot.AssertDataGridViewNumericUpDownCellValue("requirementDetailForm", "commentDataGridView", 0, 2, "None");
        }


        [TestMethod]
        [DeploymentItem("RMS_Project.exe")]
        public void EditRequirementData()
        {
            //設定帳密
            Robot.SetOtherFormEdit("loginForm", "emailLabel", "j00064qaz123@gmail.com");
            Robot.SetOtherFormUseSystemPasswordChar("loginForm", "passwordLabel", "a123456");

            //確認登入資料
            Robot.AssertOtherFormEdit("loginForm", "emailLabel", "j00064qaz123@gmail.com");
            Robot.ClickOtherFormButton("loginForm", "signInButton");

            Robot.ClickDataGridView("projectListForm", "projectDataGridView", 0, 0, 550, 3);


            Robot.ClickOtherFormDoubleButton("projectMainForm", "requirementButton");

            
            Robot.ClickDataGridView("requirementListForm", "requirementListDataGridView", 0, 0, 300, 3);

            Robot.AssertWindowExist("requirementDetailForm", true);

            Robot.ClickOtherFormButton("UserInterfaceForm", "NewProjectButton");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "priorityComboBox", "Medium");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "handlerComboBox", "YH");

            Robot.SetOtherFormEdit("requirementEditorForm", "memoLabel", "None!");

            Robot.ClickOtherFormButton("requirementEditorForm", "confirmButton");
            Robot.AssertWindowExist("Success", true);
            Robot.ClickOtherFormButton("Success", "確定");

            Robot.AssertOtherText("requirementDetailForm", "priorityLabel", "Medium");
            Robot.AssertOtherText("requirementDetailForm", "handlerLabel", "YH");
            //Robot.AssertOtherText("requirementDetailForm", "memoTextBox", "None!");


        }
    }
}
