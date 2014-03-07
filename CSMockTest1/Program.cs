using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CSMockTest1.Views;
using CSMockTest1.Controllers;

namespace CSMockTest1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainView mainView = new MainView();
            MainViewController mainViewController = new MainViewController(mainView);
            mainView.setController(mainViewController);
            Application.Run(mainView);
        }
    }
}
