using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSMockTest1.Views;

namespace CSMockTest1.Controllers
{
    public class MainViewController
    {
        private IMainView view;

        public MainViewController(IMainView _view)
        {
            view = _view;
        }
    }
}
