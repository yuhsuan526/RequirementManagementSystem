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
    /// TestGUITestMatrixAll 的摘要描述
    /// </summary>
    [CodedUITest]
    public class TestGUITestMatrixAll
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

        public void AddTestRequirementData()
        {
            //設定帳密
            Robot.SetOtherFormEdit("loginForm", "emailLabel", "j00064qaz123@gmail.com");
            Robot.SetOtherFormUseSystemPasswordChar("loginForm", "passwordLabel", "a123456");

            //確認登入資料
            Robot.AssertOtherFormEdit("loginForm", "emailLabel", "j00064qaz123@gmail.com");
            Robot.ClickOtherFormButton("loginForm", "signInButton");

            Robot.AssertWindowExist("projectListForm", true);

            Robot.ClickDataGridView("projectListForm", "projectDataGridView", 0, 0, 550, 3);

            Robot.AssertWindowExist("projectMainForm", true);

            Robot.ClickOtherFormButton("projectMainForm", "requirementButton");

            Robot.AssertWindowExist("requirementListForm", true);
            
            //requirement1
            Robot.ClickOtherFormButton("UserInterfaceForm", "NewProjectButton");
            Robot.SetOtherFormEdit("requirementEditorForm", "requirementName", "讀檔要求");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "typeComboBox", "functional");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "priorityComboBox", "High");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "statusComboBox", "Open");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "handlerComboBox", "ZZ");
            Robot.SetOtherFormEdit("requirementEditorForm", "descriptionLabel", "程式能讀取空的.txt 檔，讀入前如果有未存檔的圖形正在編輯，跳出警告視窗。詢問使用者是否先存檔之後再讀取新的檔案。");
            Robot.SetOtherFormEdit("requirementEditorForm", "memoLabel", "none");
            Robot.ClickOtherFormButton("requirementEditorForm", "confirmButton");
            Robot.AssertWindowExist("Success", true);
            Robot.ClickOtherFormButton("Success", "確定");
            Robot.AssertDataGridViewNumericUpDownCellValue("requirementListForm", "requirementListDataGridView", 0, 0, "讀檔要求");

            //requirement2
            Robot.ClickOtherFormButton("UserInterfaceForm", "NewProjectButton");
            Robot.SetOtherFormEdit("requirementEditorForm", "requirementName", "寫檔要求");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "typeComboBox", "functional");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "priorityComboBox", "High");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "statusComboBox", "Approved");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "handlerComboBox", "ZZ");
            Robot.SetOtherFormEdit("requirementEditorForm", "descriptionLabel", "畫面中沒有圖形也能存檔。");
            Robot.SetOtherFormEdit("requirementEditorForm", "memoLabel", "none");
            Robot.ClickOtherFormButton("requirementEditorForm", "confirmButton");
            Robot.AssertWindowExist("Success", true);
            Robot.ClickOtherFormButton("Success", "確定");
            Robot.AssertDataGridViewNumericUpDownCellValue("requirementListForm", "requirementListDataGridView", 0, 0, "寫檔要求");

            //requirement3
            Robot.ClickOtherFormButton("UserInterfaceForm", "NewProjectButton");
            Robot.SetOtherFormEdit("requirementEditorForm", "requirementName", "圖形按鈕永遠enable");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "typeComboBox", "functional");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "priorityComboBox", "High");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "statusComboBox", "Not approved");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "handlerComboBox", "ZZ");
            Robot.SetOtherFormEdit("requirementEditorForm", "descriptionLabel", "新增方形、圓形、長方形的按鈕永遠 enable。");
            Robot.SetOtherFormEdit("requirementEditorForm", "memoLabel", "none");
            Robot.ClickOtherFormButton("requirementEditorForm", "confirmButton");
            Robot.AssertWindowExist("Success", true);
            Robot.ClickOtherFormButton("Success", "確定");
            Robot.AssertDataGridViewNumericUpDownCellValue("requirementListForm", "requirementListDataGridView", 0, 0, "圖形按鈕永遠enable");

            //requirement4
            Robot.ClickOtherFormButton("UserInterfaceForm", "NewProjectButton");
            Robot.SetOtherFormEdit("requirementEditorForm", "requirementName", "圖形狀態");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "typeComboBox", "functional");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "priorityComboBox", "High");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "statusComboBox", "Open");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "handlerComboBox", "ZZ");
            Robot.SetOtherFormEdit("requirementEditorForm", "descriptionLabel", "唯有當圖形狀態被改變時，undo 按鈕需為 enable，其他時候為 disable。");
            Robot.SetOtherFormEdit("requirementEditorForm", "memoLabel", "存檔/讀檔本身無法被 undo/redo");
            Robot.ClickOtherFormButton("requirementEditorForm", "confirmButton");
            Robot.AssertWindowExist("Success", true);
            Robot.ClickOtherFormButton("Success", "確定");
            Robot.AssertDataGridViewNumericUpDownCellValue("requirementListForm", "requirementListDataGridView", 0, 0, "圖形狀態");

            //requirement5
            Robot.ClickOtherFormButton("UserInterfaceForm", "NewProjectButton");
            Robot.SetOtherFormEdit("requirementEditorForm", "requirementName", "undo按鈕需求");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "typeComboBox", "functional");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "priorityComboBox", "High");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "statusComboBox", "Open");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "handlerComboBox", "ZZ");
            Robot.SetOtherFormEdit("requirementEditorForm", "descriptionLabel", "唯有當圖形狀態被改變時，undo 按鈕需為 enable，其他時候為 disable。");
            Robot.SetOtherFormEdit("requirementEditorForm", "memoLabel", "存檔/讀檔本身無法被 undo");
            Robot.ClickOtherFormButton("requirementEditorForm", "confirmButton");
            Robot.AssertWindowExist("Success", true);
            Robot.ClickOtherFormButton("Success", "確定");
            Robot.AssertDataGridViewNumericUpDownCellValue("requirementListForm", "requirementListDataGridView", 0, 0, "undo按鈕需求");

            //requirement6
            Robot.ClickOtherFormButton("UserInterfaceForm", "NewProjectButton");
            Robot.SetOtherFormEdit("requirementEditorForm", "requirementName", "redo按鈕需求");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "typeComboBox", "functional");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "priorityComboBox", "High");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "statusComboBox", "Open");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "handlerComboBox", "ZZ");
            Robot.SetOtherFormEdit("requirementEditorForm", "descriptionLabel", "唯有當圖形狀態被 undo 時, redo 按鈕需為 enable，其他時候為 disable。");
            Robot.SetOtherFormEdit("requirementEditorForm", "memoLabel", "存檔/讀檔本身無法被 redo");
            Robot.ClickOtherFormButton("requirementEditorForm", "confirmButton");
            Robot.AssertWindowExist("Success", true);
            Robot.ClickOtherFormButton("Success", "確定");
            Robot.AssertDataGridViewNumericUpDownCellValue("requirementListForm", "requirementListDataGridView", 0, 0, "redo按鈕需求");

            //requirement7
            Robot.ClickOtherFormButton("UserInterfaceForm", "NewProjectButton");
            Robot.SetOtherFormEdit("requirementEditorForm", "requirementName", "讀檔之後，command stack需求");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "typeComboBox", "functional");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "priorityComboBox", "High");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "statusComboBox", "Approved");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "handlerComboBox", "ZZ");
            Robot.SetOtherFormEdit("requirementEditorForm", "descriptionLabel", "讀檔之後，需清空 command stack，並將 redo、undo 按鈕設為 disable。");
            Robot.SetOtherFormEdit("requirementEditorForm", "memoLabel", "none");
            Robot.ClickOtherFormButton("requirementEditorForm", "confirmButton");
            Robot.AssertWindowExist("Success", true);
            Robot.ClickOtherFormButton("Success", "確定");
            Robot.AssertDataGridViewNumericUpDownCellValue("requirementListForm", "requirementListDataGridView", 0, 0, "讀檔之後，command stack需求");

            //requirement8
            Robot.ClickOtherFormButton("UserInterfaceForm", "NewProjectButton");
            Robot.SetOtherFormEdit("requirementEditorForm", "requirementName", "讀檔之後，command stack需求");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "typeComboBox", "functional");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "priorityComboBox", "High");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "statusComboBox", "Approved");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "handlerComboBox", "ZZ");
            Robot.SetOtherFormEdit("requirementEditorForm", "descriptionLabel", "讀檔之後，需清空 command stack，並將 redo、undo 按鈕設為 disable。");
            Robot.SetOtherFormEdit("requirementEditorForm", "memoLabel", "none");
            Robot.ClickOtherFormButton("requirementEditorForm", "confirmButton");
            Robot.AssertWindowExist("Success", true);
            Robot.ClickOtherFormButton("Success", "確定");
            Robot.AssertDataGridViewNumericUpDownCellValue("requirementListForm", "requirementListDataGridView", 0, 0, "讀檔之後，command stack需求");

        }
    }
}
