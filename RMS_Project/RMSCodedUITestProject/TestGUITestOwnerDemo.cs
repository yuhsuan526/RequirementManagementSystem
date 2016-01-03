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
    /// TestGUITestOwnerDemo 的摘要描述
    /// </summary>
    [CodedUITest]
    public class TestGUITestOwnerDemo
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
        public void OwnerDemo()
        {
            Robot.SetOtherFormEdit("loginForm", "emailLabel", "test@gmail.com");
            Robot.SetOtherFormUseSystemPasswordChar("loginForm", "passwordLabel", "123456");

            //確認登入資料
            Robot.AssertOtherFormEdit("loginForm", "emailLabel", "test@gmail.com");
            Robot.ClickOtherFormButton("loginForm", "signInButton");

            Robot.AssertWindowExist("projectListForm", true);

            Robot.ClickOtherFormButton("UserInterfaceForm", "NewProjectButton");
            Robot.SetOtherFormEdit("ProjectEditorForm", "ProjectName", "POSD_HW7");
            Robot.SetOtherFormEdit("ProjectEditorForm", "ProjectDescription", "本次作業須接續上ㄧ次作業的功能繼續擴充，需要套入 MVC 架構，讓 View 只專心處理畫面，與 GUI 無關的程式、變數移動到 Model 中。為了讓 GUI 的按鈕能隨著使用者操作動態更新狀態，須套入 observer pattern 來達到此目的。");

            Robot.ClickOtherFormButton("ProjectEditorForm", "Confirm");

            Robot.AssertWindowExist("Success", true);
            Robot.ClickOtherFormButton("Success", "確定");

            Robot.AssertWindowExist("projectListForm", true);

            Robot.ClickDataGridView("projectListForm", "projectDataGridView", 0, 0, 550, 3);

            Robot.AssertWindowExist("projectMainForm", true);

            Robot.ClickOtherFormButton("ProjectMainForm", "memberButton");


            Robot.SetOtherFormEdit("userListForm", "userName", "anglebeats711529@gmail.com");
            Robot.ClickOtherFormComboBox("userListForm", "priorityComboBox", "Manager");
            Robot.ClickOtherFormButton("UserInterfaceForm", "NewProjectButton");
            Robot.AssertWindowExist("Success", true);
            Robot.ClickOtherFormButton("Success", "確定");

            Robot.SetOtherFormEdit("userListForm", "userName", "hsiaohan0614@gmail.com");
            Robot.ClickOtherFormComboBox("userListForm", "priorityComboBox", "Member");
            Robot.ClickOtherFormButton("UserInterfaceForm", "NewProjectButton");
            //Robot.AssertWindowExist("Success", true);
            Robot.ClickOtherFormButton("Success", "確定");

            Robot.SetOtherFormEdit("userListForm", "userName", "j00064qaz123@gmail.com");
            Robot.ClickOtherFormComboBox("userListForm", "priorityComboBox", "Member");
            Robot.ClickOtherFormButton("UserInterfaceForm", "NewProjectButton");
            //Robot.AssertWindowExist("Success", true);
            Robot.ClickOtherFormButton("Success", "確定");

            Robot.SetOtherFormEdit("userListForm", "userName", "pcf2200@gmail.com");
            Robot.ClickOtherFormComboBox("userListForm", "priorityComboBox", "Member");
            Robot.ClickOtherFormButton("UserInterfaceForm", "NewProjectButton");
            //Robot.AssertWindowExist("Success", true);
            Robot.ClickOtherFormButton("Success", "確定");

            Robot.SetOtherFormEdit("userListForm", "userName", "t104598001@ntut.edu.tw");
            Robot.ClickOtherFormComboBox("userListForm", "priorityComboBox", "Member");
            Robot.ClickOtherFormButton("UserInterfaceForm", "NewProjectButton");
            //Robot.AssertWindowExist("Success", true);
            Robot.ClickOtherFormButton("Success", "確定");

            Robot.SetOtherFormEdit("userListForm", "userName", "cliu@ntut.edu.tw");
            Robot.ClickOtherFormComboBox("userListForm", "priorityComboBox", "Customer");
            Robot.ClickOtherFormButton("UserInterfaceForm", "NewProjectButton");
            //Robot.AssertWindowExist("Success", true);
            Robot.ClickOtherFormButton("Success", "確定");

            Robot.AssertWindowExist("projectMainForm", true);

            Robot.ClickOtherFormButton("projectMainForm", "requirementButton");

            Robot.AssertWindowExist("requirementListForm", true);

            //requirement1
            Robot.ClickOtherFormButton("UserInterfaceForm", "NewProjectButton");
            Robot.SetOtherFormEdit("requirementEditorForm", "requirementName", "讀檔要求\n");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "typeComboBox", "functional");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "priorityComboBox", "High");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "statusComboBox", "Open");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "handlerComboBox", "廖振諺");
            Robot.SetOtherFormEdit("requirementEditorForm", "descriptionLabel", "程式能讀取空的.txt 檔，讀入前如果有未存檔的圖形正在編輯，跳出警告視窗。詢問使用者是否先存檔之後再讀取新的檔案。\n");
            Robot.SetOtherFormEdit("requirementEditorForm", "memoLabel", "none");
            Robot.ClickOtherFormButton("requirementEditorForm", "confirmButton");
            Robot.AssertWindowExist("Success", true);
            Robot.ClickOtherFormButton("Success", "確定");
            Robot.AssertWindowExist("requirementListForm", true);
            Robot.AssertDataGridViewNumericUpDownCellValue("requirementListForm", "requirementListDataGridView", 0, 0, "讀檔要求");

            //requirement2
            Robot.ClickOtherFormButton("UserInterfaceForm", "NewProjectButton");
            Robot.SetOtherFormEdit("requirementEditorForm", "requirementName", "寫檔要求\n");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "typeComboBox", "functional");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "priorityComboBox", "High");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "statusComboBox", "Approved");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "handlerComboBox", "廖振諺");
            Robot.SetOtherFormEdit("requirementEditorForm", "descriptionLabel", "畫面中沒有圖形也能存檔。\n");
            Robot.SetOtherFormEdit("requirementEditorForm", "memoLabel", "none");
            Robot.ClickOtherFormButton("requirementEditorForm", "confirmButton");
            //Robot.AssertWindowExist("Success", true);
            Robot.ClickOtherFormButton("Success", "確定");
            Robot.AssertWindowExist("requirementListForm", true);
            Robot.AssertDataGridViewNumericUpDownCellValue("requirementListForm", "requirementListDataGridView", 1, 0, "寫檔要求");

            //requirement3
            Robot.ClickOtherFormButton("UserInterfaceForm", "NewProjectButton");
            Robot.SetOtherFormEdit("requirementEditorForm", "requirementName", "圖形按鈕永遠enable\n");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "typeComboBox", "functional");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "priorityComboBox", "High");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "statusComboBox", "Not approved");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "handlerComboBox", "廖振諺");
            Robot.SetOtherFormEdit("requirementEditorForm", "descriptionLabel", "新增方形、圓形、長方形的按鈕永遠 enable。\n");
            Robot.SetOtherFormEdit("requirementEditorForm", "memoLabel", "none");
            Robot.ClickOtherFormButton("requirementEditorForm", "confirmButton");
            //Robot.AssertWindowExist("Success", true);
            Robot.ClickOtherFormButton("Success", "確定");
            Robot.AssertWindowExist("requirementListForm", true);
            Robot.AssertDataGridViewNumericUpDownCellValue("requirementListForm", "requirementListDataGridView", 2, 0, "圖形按鈕永遠enable");

            //requirement4
            Robot.ClickOtherFormButton("UserInterfaceForm", "NewProjectButton");
            Robot.SetOtherFormEdit("requirementEditorForm", "requirementName", "圖形狀態\n");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "typeComboBox", "functional");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "priorityComboBox", "High");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "statusComboBox", "Open");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "handlerComboBox", "杜筱菡");
            Robot.SetOtherFormEdit("requirementEditorForm", "descriptionLabel", "唯有當圖形狀態被改變時，undo 按鈕需為 enable，其他時候為 disable。\n");
            Robot.SetOtherFormEdit("requirementEditorForm", "memoLabel", "存檔/讀檔本身無法被 undo/redo\n");
            Robot.ClickOtherFormButton("requirementEditorForm", "confirmButton");
            //Robot.AssertWindowExist("Success", true);
            Robot.ClickOtherFormButton("Success", "確定");
            Robot.AssertWindowExist("requirementListForm", true);
            Robot.AssertDataGridViewNumericUpDownCellValue("requirementListForm", "requirementListDataGridView", 3, 0, "圖形狀態");

            //requirement5
            Robot.ClickOtherFormButton("UserInterfaceForm", "NewProjectButton");
            Robot.SetOtherFormEdit("requirementEditorForm", "requirementName", "undo按鈕需求\n");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "typeComboBox", "functional");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "priorityComboBox", "High");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "statusComboBox", "Open");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "handlerComboBox", "杜筱菡");
            Robot.SetOtherFormEdit("requirementEditorForm", "descriptionLabel", "唯有當圖形狀態被改變時，undo 按鈕需為 enable，其他時候為 disable。\n");
            Robot.SetOtherFormEdit("requirementEditorForm", "memoLabel", "存檔/讀檔本身無法被 undo\n");
            Robot.ClickOtherFormButton("requirementEditorForm", "confirmButton");
            //Robot.AssertWindowExist("Success", true);
            Robot.ClickOtherFormButton("Success", "確定");
            Robot.AssertWindowExist("requirementListForm", true);
            Robot.AssertDataGridViewNumericUpDownCellValue("requirementListForm", "requirementListDataGridView", 4, 0, "undo按鈕需求");

            //requirement6
            Robot.ClickOtherFormButton("UserInterfaceForm", "NewProjectButton");
            Robot.SetOtherFormEdit("requirementEditorForm", "requirementName", "redo按鈕需求\n");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "typeComboBox", "functional");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "priorityComboBox", "High");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "statusComboBox", "Open");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "handlerComboBox", "杜筱菡");
            Robot.SetOtherFormEdit("requirementEditorForm", "descriptionLabel", "唯有當圖形狀態被 undo 時, redo 按鈕需為 enable，其他時候為 disable。\n");
            Robot.SetOtherFormEdit("requirementEditorForm", "memoLabel", "存檔/讀檔本身無法被 redo\n");
            Robot.ClickOtherFormButton("requirementEditorForm", "confirmButton");
            //Robot.AssertWindowExist("Success", true);
            Robot.ClickOtherFormButton("Success", "確定");
            Robot.AssertWindowExist("requirementListForm", true);
            Robot.AssertDataGridViewNumericUpDownCellValue("requirementListForm", "requirementListDataGridView", 5, 0, "redo按鈕需求");

            //requirement7
            Robot.ClickOtherFormButton("UserInterfaceForm", "NewProjectButton");
            Robot.SetOtherFormEdit("requirementEditorForm", "requirementName", "讀檔後command_stack需求\n");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "typeComboBox", "functional");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "priorityComboBox", "High");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "statusComboBox", "Approved");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "handlerComboBox", "洪學儒");
            Robot.SetOtherFormEdit("requirementEditorForm", "descriptionLabel", "讀檔之後，需清空 command stack，並將 redo、undo 按鈕設為 disable。\n");
            Robot.SetOtherFormEdit("requirementEditorForm", "memoLabel", "none");
            Robot.ClickOtherFormButton("requirementEditorForm", "confirmButton");
            //Robot.AssertWindowExist("Success", true);
            Robot.ClickOtherFormButton("Success", "確定");
            Robot.AssertWindowExist("requirementListForm", true);
            Robot.AssertDataGridViewNumericUpDownCellValue("requirementListForm", "requirementListDataGridView", 6, 0, "讀檔後command_stack需求");


            //requirement8
            Robot.ClickOtherFormButton("UserInterfaceForm", "NewProjectButton");
            Robot.SetOtherFormEdit("requirementEditorForm", "requirementName", "存檔後command_stack需求\n");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "typeComboBox", "functional");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "priorityComboBox", "High");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "statusComboBox", "Approved");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "handlerComboBox", "洪學儒");
            Robot.SetOtherFormEdit("requirementEditorForm", "descriptionLabel", "存檔之後，依然能夠繼續 redo、undo。\n");
            Robot.SetOtherFormEdit("requirementEditorForm", "memoLabel", "redo,undo 按鈕需為 enable");
            Robot.ClickOtherFormButton("requirementEditorForm", "confirmButton");
            //Robot.AssertWindowExist("Success", true);
            Robot.ClickOtherFormButton("Success", "確定");
            Robot.AssertWindowExist("requirementListForm", true);
            Robot.AssertDataGridViewNumericUpDownCellValue("requirementListForm", "requirementListDataGridView", 7, 0, "存檔後command_stack需求");

            //requirement9
            Robot.ClickOtherFormButton("UserInterfaceForm", "NewProjectButton");
            Robot.SetOtherFormEdit("requirementEditorForm", "requirementName", "group按鈕需求\n");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "typeComboBox", "functional");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "priorityComboBox", "High");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "statusComboBox", "Under review");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "handlerComboBox", "洪學儒");
            Robot.SetOtherFormEdit("requirementEditorForm", "descriptionLabel", "唯有當選取複數且皆為 root 的圖形時，group 按鈕需為 enable，其他時候為 disable。\n");
            Robot.SetOtherFormEdit("requirementEditorForm", "memoLabel", "none");
            Robot.ClickOtherFormButton("requirementEditorForm", "confirmButton");
            //Robot.AssertWindowExist("Success", true);
            Robot.ClickOtherFormButton("Success", "確定");
            Robot.AssertWindowExist("requirementListForm", true);
            Robot.AssertDataGridViewNumericUpDownCellValue("requirementListForm", "requirementListDataGridView", 8, 0, "group按鈕需求");

            //requirement10
            Robot.ClickOtherFormButton("UserInterfaceForm", "NewProjectButton");
            Robot.SetOtherFormEdit("requirementEditorForm", "requirementName", "ungroup按鈕需求\n");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "typeComboBox", "functional");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "priorityComboBox", "High");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "statusComboBox", "Under review");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "handlerComboBox", "劉有軒");
            Robot.SetOtherFormEdit("requirementEditorForm", "descriptionLabel", "唯有選取單一個且為 root 的 composite graphic 時，ungroup 按鈕需為 enable，其他時候為 disable。\n");
            Robot.SetOtherFormEdit("requirementEditorForm", "memoLabel", "none");
            Robot.ClickOtherFormButton("requirementEditorForm", "confirmButton");
            //Robot.AssertWindowExist("Success", true);
            Robot.ClickOtherFormButton("Success", "確定");
            Robot.AssertWindowExist("requirementListForm", true);
            Robot.AssertDataGridViewNumericUpDownCellValue("requirementListForm", "requirementListDataGridView", 9, 0, "ungroup按鈕需求");

            //requirement11
            Robot.ClickOtherFormButton("UserInterfaceForm", "NewProjectButton");
            Robot.SetOtherFormEdit("requirementEditorForm", "requirementName", "delete按鈕需求\n");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "typeComboBox", "functional");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "priorityComboBox", "High");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "statusComboBox", "Under review");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "handlerComboBox", "劉有軒");
            Robot.SetOtherFormEdit("requirementEditorForm", "descriptionLabel", "唯有選取單一個且為 root 的圖形時，delete 按鈕需為 enable，其他時候為 disable。\n");
            Robot.SetOtherFormEdit("requirementEditorForm", "memoLabel", "none");
            Robot.ClickOtherFormButton("requirementEditorForm", "confirmButton");
            //Robot.AssertWindowExist("Success", true);
            Robot.ClickOtherFormButton("Success", "確定");
            Robot.AssertWindowExist("requirementListForm", true);
            Robot.AssertDataGridViewNumericUpDownCellValue("requirementListForm", "requirementListDataGridView", 10, 0, "delete按鈕需求");

            //requirement12
            Robot.ClickOtherFormButton("UserInterfaceForm", "NewProjectButton");
            Robot.SetOtherFormEdit("requirementEditorForm", "requirementName", "圖層需求\n");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "typeComboBox", "functional");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "priorityComboBox", "High");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "statusComboBox", "Under review");
            Robot.ClickOtherFormComboBox("requirementEditorForm", "handlerComboBox", "劉有軒");
            Robot.SetOtherFormEdit("requirementEditorForm", "descriptionLabel", "當選取單一個 composite graphic 或其中的 simple graphic 時，若該圖形具備上下層移動的條件，move up、move down 按鈕需為 enable，其他時候為 disable。\n");
            Robot.SetOtherFormEdit("requirementEditorForm", "memoLabel", "(參照 HW6)\n");
            Robot.ClickOtherFormButton("requirementEditorForm", "confirmButton");
            //Robot.AssertWindowExist("Success", true);
            Robot.ClickOtherFormButton("Success", "確定");
            //Robot.AssertWindowExist("requirementListForm", true);
            //Robot.AssertDataGridViewNumericUpDownCellValue("requirementListForm", "requirementListDataGridView", 11, 0, "圖層需求");


            Robot.AssertWindowExist("ProjectMainForm", true);

            Robot.ClickOtherFormButton("ProjectMainForm", "testButton");

            Robot.AssertWindowExist("testListForm", true);

            //Test1
            Robot.ClickOtherFormButton("UserInterfaceForm", "NewProjectButton");
            Robot.SetOtherFormEdit("testEditorForm", "testName", "讀存檔測試\n");
            Robot.SetOtherFormEdit("testEditorForm", "testInputData", "讀/存檔\n");
            Robot.SetOtherFormEdit("testEditorForm", "testResult", "可以讀出圖形跟存圖形\n");
            Robot.ClickOtherFormComboBox("testEditorForm", "ownerCombobox", "李宗哲");
            Robot.SetOtherFormEdit("testEditorForm", "testDescription", "存檔/讀檔按鈕更新狀態(10 分)\n");
            Robot.CheckTheCheckedListBox("testEditorForm", "checkedListBox", 0, true);
            Robot.CheckTheCheckedListBox("testEditorForm", "checkedListBox", 1, true);
            Robot.CheckTheCheckedListBox("testEditorForm", "checkedListBox", 6, true);
            Robot.CheckTheCheckedListBox("testEditorForm", "checkedListBox", 7, true);
            Robot.ClickOtherFormButton("testEditorForm", "testConfirm");
            //Robot.AssertWindowExist("Success", true);
            Robot.ClickOtherFormButton("Success", "確定");
            Robot.AssertWindowExist("testListForm", true);
            Robot.AssertDataGridViewNumericUpDownCellValue("testListForm", "testListDataGridView", 0, 0, "讀存檔測試");

            //Test2
            Robot.ClickOtherFormButton("UserInterfaceForm", "NewProjectButton");
            Robot.SetOtherFormEdit("testEditorForm", "testName", "新增圖形測試\n");
            Robot.SetOtherFormEdit("testEditorForm", "testInputData", "可以增加圓形、方形、正方形\n");
            Robot.SetOtherFormEdit("testEditorForm", "testResult", "scene出現圓形、方形、正方形\n");
            Robot.ClickOtherFormComboBox("testEditorForm", "ownerCombobox", "李宗哲");
            Robot.SetOtherFormEdit("testEditorForm", "testDescription", "三個新增圖形按鈕更新狀態(10 分)\n");
            Robot.CheckTheCheckedListBox("testEditorForm", "checkedListBox", 0, true);
            Robot.CheckTheCheckedListBox("testEditorForm", "checkedListBox", 1, true);
            Robot.CheckTheCheckedListBox("testEditorForm", "checkedListBox", 2, true);
            Robot.CheckTheCheckedListBox("testEditorForm", "checkedListBox", 3, true);
            Robot.CheckTheCheckedListBox("testEditorForm", "checkedListBox", 4, true);
            Robot.CheckTheCheckedListBox("testEditorForm", "checkedListBox", 5, true);
            Robot.ClickOtherFormButton("testEditorForm", "testConfirm");
            //Robot.AssertWindowExist("Success", true);
            Robot.ClickOtherFormButton("Success", "確定");
            Robot.AssertWindowExist("testListForm", true);
            Robot.AssertDataGridViewNumericUpDownCellValue("testListForm", "testListDataGridView", 1, 0, "新增圖形測試");

            //Test3
            Robot.ClickOtherFormButton("UserInterfaceForm", "NewProjectButton");
            Robot.SetOtherFormEdit("testEditorForm", "testName", "圖形狀態測試\n");
            Robot.SetOtherFormEdit("testEditorForm", "testInputData", "圖形狀態被改變\n");
            Robot.SetOtherFormEdit("testEditorForm", "testResult", "undo 按鈕需為 enable，其他時候為 disable。\n");
            Robot.ClickOtherFormComboBox("testEditorForm", "ownerCombobox", "李宗哲");
            Robot.SetOtherFormEdit("testEditorForm", "testDescription", "undo/redo 按鈕更新狀態(10 分)\n");
            Robot.CheckTheCheckedListBox("testEditorForm", "checkedListBox", 3, true);
            Robot.CheckTheCheckedListBox("testEditorForm", "checkedListBox", 4, true);
            Robot.CheckTheCheckedListBox("testEditorForm", "checkedListBox", 5, true);
            Robot.ClickOtherFormButton("testEditorForm", "testConfirm");
            //Robot.AssertWindowExist("Success", true);
            Robot.ClickOtherFormButton("Success", "確定");
            Robot.AssertWindowExist("testListForm", true);
            Robot.AssertDataGridViewNumericUpDownCellValue("testListForm", "testListDataGridView", 2, 0, "圖形狀態測試");

            //Test4
            Robot.ClickOtherFormButton("UserInterfaceForm", "NewProjectButton");
            Robot.SetOtherFormEdit("testEditorForm", "testName", "group按鈕需求測試\n");
            Robot.SetOtherFormEdit("testEditorForm", "testInputData", "點選兩個圖形，按下Group UI\n");
            Robot.SetOtherFormEdit("testEditorForm", "testResult", "兩個圖形會變成一個comp\n");
            Robot.ClickOtherFormComboBox("testEditorForm", "ownerCombobox", "李宗哲");
            Robot.SetOtherFormEdit("testEditorForm", "testDescription", "group/ungroup 按鈕更新狀態(10 分)\n");
            Robot.CheckTheCheckedListBox("testEditorForm", "checkedListBox", 4, true);
            Robot.CheckTheCheckedListBox("testEditorForm", "checkedListBox", 5, true);
            Robot.CheckTheCheckedListBox("testEditorForm", "checkedListBox", 8, true);
            Robot.ClickOtherFormButton("testEditorForm", "testConfirm");
            //Robot.AssertWindowExist("Success", true);
            Robot.ClickOtherFormButton("Success", "確定");
            Robot.AssertWindowExist("testListForm", true);
            Robot.AssertDataGridViewNumericUpDownCellValue("testListForm", "testListDataGridView", 3, 0, "group按鈕需求測試");

            //Test5
            Robot.ClickOtherFormButton("UserInterfaceForm", "NewProjectButton");
            Robot.SetOtherFormEdit("testEditorForm", "testName", "ungroup按鈕需求測試\n");
            Robot.SetOtherFormEdit("testEditorForm", "testInputData", "點選一個comp圖形，按下unGroup UI\n");
            Robot.SetOtherFormEdit("testEditorForm", "testResult", "一個comp會變成兩個圖形\n");
            Robot.ClickOtherFormComboBox("testEditorForm", "ownerCombobox", "李宗哲");
            Robot.SetOtherFormEdit("testEditorForm", "testDescription", "group/ungroup 按鈕更新狀態(10 分)，有可能是simple+simple+..../simple+comp+...../comp+comp+.....\n");
            Robot.CheckTheCheckedListBox("testEditorForm", "checkedListBox", 4, true);
            Robot.CheckTheCheckedListBox("testEditorForm", "checkedListBox", 5, true);
            Robot.CheckTheCheckedListBox("testEditorForm", "checkedListBox", 9, true);
            Robot.ClickOtherFormButton("testEditorForm", "testConfirm");
            //Robot.AssertWindowExist("Success", true);
            Robot.ClickOtherFormButton("Success", "確定");
            Robot.AssertWindowExist("testListForm", true);
            Robot.AssertDataGridViewNumericUpDownCellValue("testListForm", "testListDataGridView", 4, 0, "ungroup按鈕需求測試");

            //Test6
            Robot.ClickOtherFormButton("UserInterfaceForm", "NewProjectButton");
            Robot.SetOtherFormEdit("testEditorForm", "testName", "delete按鈕需求測試\n");
            Robot.SetOtherFormEdit("testEditorForm", "testInputData", "點選一個圖形，按下delete UI\n");
            Robot.SetOtherFormEdit("testEditorForm", "testResult", "此圖形會被刪除\n");
            Robot.ClickOtherFormComboBox("testEditorForm", "ownerCombobox", "李宗哲");
            Robot.SetOtherFormEdit("testEditorForm", "testDescription", "delete 按鈕更新狀態(10 分)，有可能是simple+simple+..../simple+comp+...../comp+comp+.....\n");
            Robot.CheckTheCheckedListBox("testEditorForm", "checkedListBox", 4, true);
            Robot.CheckTheCheckedListBox("testEditorForm", "checkedListBox", 5, true);
            Robot.CheckTheCheckedListBox("testEditorForm", "checkedListBox", 10, true);
            Robot.ClickOtherFormButton("testEditorForm", "testConfirm");
            //Robot.AssertWindowExist("Success", true);
            Robot.ClickOtherFormButton("Success", "確定");
            Robot.AssertWindowExist("testListForm", true);
            Robot.AssertDataGridViewNumericUpDownCellValue("testListForm", "testListDataGridView", 5, 0, "delete按鈕需求測試");

            //Test7
            Robot.ClickOtherFormButton("UserInterfaceForm", "NewProjectButton");
            Robot.SetOtherFormEdit("testEditorForm", "testName", "move up/move down 按鈕測試\n");
            Robot.SetOtherFormEdit("testEditorForm", "testInputData", "點選一個comp圖形，按下move up/move down UI\n");
            Robot.SetOtherFormEdit("testEditorForm", "testResult", "此圖形圖層會改變\n");
            Robot.ClickOtherFormComboBox("testEditorForm", "ownerCombobox", "李宗哲");
            Robot.SetOtherFormEdit("testEditorForm", "testDescription", "move up/move down 按鈕更新狀態(10 分)\n");
            Robot.CheckTheCheckedListBox("testEditorForm", "checkedListBox", 4, true);
            Robot.CheckTheCheckedListBox("testEditorForm", "checkedListBox", 5, true);
            Robot.CheckTheCheckedListBox("testEditorForm", "checkedListBox", 11, true);
            Robot.ClickOtherFormButton("testEditorForm", "testConfirm");
            //Robot.AssertWindowExist("Success", true);
            Robot.ClickOtherFormButton("Success", "確定");
            Robot.AssertWindowExist("testListForm", true);
            Robot.AssertDataGridViewNumericUpDownCellValue("testListForm", "testListDataGridView", 6, 0, "move up/move down 按鈕測試");

            //Test8
            Robot.ClickOtherFormButton("UserInterfaceForm", "NewProjectButton");
            Robot.SetOtherFormEdit("testEditorForm", "testName", "助教測試\n");
            Robot.SetOtherFormEdit("testEditorForm", "testInputData", "所有功能\n");
            Robot.SetOtherFormEdit("testEditorForm", "testResult", "助教測試\n");
            Robot.ClickOtherFormComboBox("testEditorForm", "ownerCombobox", "李宗哲");
            Robot.SetOtherFormEdit("testEditorForm", "testDescription", "助教測資(20 分)\n");
            Robot.ClickOtherFormButton("testEditorForm", "testConfirm");
            //Robot.AssertWindowExist("Success", true);
            Robot.ClickOtherFormButton("Success", "確定");
            //Robot.AssertWindowExist("testListForm", true);
            //Robot.AssertDataGridViewNumericUpDownCellValue("testListForm", "testListDataGridView", 7, 0, "助教測試");

            Robot.AssertWindowExist("projectMainForm", true);

            Robot.ClickOtherFormButton("projectMainForm", "otherButton");

            Robot.AssertWindowExist("traceabilityMatrixForm", true);

            //Not Approved Requirement
            Robot.ClickTabControl("traceabilityMatrixForm", "othersTabControl", "Not Approved Requirements");
            Robot.AssertWindowExist("traceabilityMatrixForm", true);

            Robot.ClickTabControl("traceabilityMatrixForm", "othersTabControl", "Traceability Matrix (R-T)");

            Robot.AssertWindowExist("traceabilityMatrixForm", true);

            Robot.ClickTabControl("traceabilityMatrixForm", "othersTabControl", "Traceability Matrix (R-R)");
            //Robot.ClickOtherDataGridView("traceabilityMatrixForm", "Traceability Matrix (R-R)", "RtoRDataGridView", 1, 3);
            Robot.AssertWindowExist("traceabilityMatrixForm", true);

            Robot.ClickTabControl("traceabilityMatrixForm", "othersTabControl", "No Associated Test Cases");
            Robot.AssertWindowExist("traceabilityMatrixForm", true);

            Robot.ClickTabControl("traceabilityMatrixForm", "othersTabControl", "No Associated Requirements");
            Robot.AssertWindowExist("traceabilityMatrixForm", true);

            Robot.ClickTabControl("traceabilityMatrixForm", "othersTabControl", "Approved Requirements");
            Robot.AssertWindowExist("traceabilityMatrixForm", true);

        }
    }
}
