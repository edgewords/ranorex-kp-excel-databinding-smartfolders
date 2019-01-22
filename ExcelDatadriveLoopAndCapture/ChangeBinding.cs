/*
 * Created by Ranorex
 * User: edgewords
 * Date: 09/01/2019
 * Time: 22:29
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
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

namespace ExcelDatadriveLoopAndCapture
{
    /// <summary>
    /// Description of ChangeBinding.
    /// </summary>
    [TestModule("24884D06-8922-4D94-9B08-867C559B72F4", ModuleType.UserCode, 1)]
    public class ChangeBinding : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ChangeBinding()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
            //Get handle on SmartFolder
            var tc = TestSuite.Current.GetTestContainer("SmartFolder");
            //Get the name of the connector to use from the Global Parameter "Data Source"
            var testsource = DataSources.Get(TestSuite.Current.Parameters["DataSource"]);
            
            //Switch and load connector before test conatiner execution.
			tc.DataContext.Source=testsource;
			tc.DataContext.Source.Load();  
        }
    }
}
