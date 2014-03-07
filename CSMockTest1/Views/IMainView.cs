using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSMockTest1.Controllers;

namespace CSMockTest1.Views
{
    public interface IMainView
    {
        void setController(MainViewController mainViewController);
    }
}
