using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CSMockTest1.Controllers;


namespace CSMockTest1.Views
{
    public partial class MainView : Form, IMainView
    {
        private MainViewController Controller;

        public MainView()
        {
            InitializeComponent();
        }

        public void setController(MainViewController mainViewController)
        {
            Controller = mainViewController;
        }
    }
}
