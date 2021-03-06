﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace ExcelDatadriveLoopAndCapture
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Search recording.
    /// </summary>
    [TestModule("5d5c6713-ac52-4586-8366-209d08fd0e47", ModuleType.Recording, 1)]
    public partial class Search : ITestModule
    {
        /// <summary>
        /// Holds an instance of the ExcelDatadriveLoopAndCaptureRepository repository.
        /// </summary>
        public static ExcelDatadriveLoopAndCaptureRepository repo = ExcelDatadriveLoopAndCaptureRepository.Instance;

        static Search instance = new Search();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Search()
        {
            searchsmart = "ranorex";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Search Instance
        {
            get { return instance; }
        }

#region Variables

        string _searchsmart;

        /// <summary>
        /// Gets or sets the value of variable searchsmart.
        /// </summary>
        [TestVariable("e22e7839-2dfa-4b98-b377-4e6e66cd88c5")]
        public string searchsmart
        {
            get { return _searchsmart; }
            set { _searchsmart = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.3")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.3")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EdgewordsTrainingAutomatedSoftware.MenuMain.Search' at 4;48.", repo.EdgewordsTrainingAutomatedSoftware.MenuMain.SearchInfo, new RecordItemIndex(0));
            repo.EdgewordsTrainingAutomatedSoftware.MenuMain.Search.Click("4;48");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EdgewordsTrainingAutomatedSoftware.MenuMain.InputTagS' at 70;14.", repo.EdgewordsTrainingAutomatedSoftware.MenuMain.InputTagSInfo, new RecordItemIndex(1));
            repo.EdgewordsTrainingAutomatedSoftware.MenuMain.InputTagS.Click("70;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$searchsmart' with focus on 'EdgewordsTrainingAutomatedSoftware.MenuMain.InputTagS'.", repo.EdgewordsTrainingAutomatedSoftware.MenuMain.InputTagSInfo, new RecordItemIndex(2));
            repo.EdgewordsTrainingAutomatedSoftware.MenuMain.InputTagS.PressKeys(searchsmart);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EdgewordsTrainingAutomatedSoftware.MenuMain.Submit' at 22;22.", repo.EdgewordsTrainingAutomatedSoftware.MenuMain.SubmitInfo, new RecordItemIndex(3));
            repo.EdgewordsTrainingAutomatedSoftware.MenuMain.Submit.Click("22;22");
            Delay.Milliseconds(200);
            
            SetSmartFolderParameter();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
