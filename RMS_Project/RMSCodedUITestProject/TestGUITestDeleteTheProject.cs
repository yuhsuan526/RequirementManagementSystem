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
    /// TestGUITestDeleteTheProject 的摘要描述
    /// </summary>
    [CodedUITest]
    public class TestGUITestDeleteTheProject
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
        public void CheckDeleteProject()
        {
            Robot.SetOtherFormEdit("loginForm", "emailLabel", "j00064qaz123@gmail.com");

            Robot.SetOtherFormUseSystemPasswordChar("loginForm", "passwordLabel", "a123456");

            Robot.AssertOtherFormEdit("loginForm", "emailLabel", "j00064qaz123@gmail.com");
            Robot.ClickOtherFormButton("loginForm", "signInButton");
            Robot.AssertWindowExist("projectListForm", true);

            Robot.ClickOtherFormButton("UserInterfaceForm", "NewProjectButton");
            Robot.SetOtherFormEdit("ProjectEditorForm", "ProjectName", "POSD_#7");
            Robot.SetOtherFormEdit("ProjectEditorForm", "ProjectDescription", "本次作業須接續上ㄧ次作業的功能繼續擴充，需要套入 MVC 架構，讓 View 只專心處理畫面，與 GUI 無關的程式、變數移動到 Model 中。為了讓 GUI 的按鈕能隨著使用者操作動態更新狀態，須套入 observer pattern 來達到此目的。");

            Robot.ClickOtherFormButton("ProjectEditorForm", "Confirm");

            Robot.AssertWindowExist("Success", true);
            Robot.ClickOtherFormButton("Success", "確定");

            Robot.ClickDataGridView("projectListForm", "projectDataGridView", 0, 1, 10, 3);

            Robot.ClickOtherFormButton("Success", "確定");

            Robot.AssertDataGridViewNumericUpDownCellValue("projectListForm", "projectDataGridView", 0, 0, "POSD_#7");
        }
    }
}
