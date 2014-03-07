using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSMockTest1.Controllers;
using CSMockTest1.Views;
using NUnit.Framework;
using NMock;


namespace CSMockTest1Tests
{
    [TestFixture]
    public class MainViewControllerTests
    {
        [Test]
        public void ExpectsWithNMock()
        {
            MockFactory mockFactory = new MockFactory();
            Mock<IMainView> _view = mockFactory.CreateMock<IMainView>();
            MainViewController sut = new MainViewController(_view.MockObject);
            _view.Expects.One.MethodWith(m => m.setDisplayText("123"));
            sut.setTextToDisplay("123");


            mockFactory.VerifyAllExpectationsHaveBeenMet();
        }
    }
}
