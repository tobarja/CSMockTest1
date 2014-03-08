using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSMockTest1.Controllers;
using CSMockTest1.Views;
using NUnit.Framework;

namespace CSMockTest1Tests
{
    [TestFixture]
    public class MainViewControllerTests
    {
        [Test]
        public void ExpectsWithNMock()
        {
            NMock.MockFactory mockFactory = new NMock.MockFactory();
            NMock.Mock<IMainView> _view = mockFactory.CreateMock<IMainView>();
            MainViewController sut = new MainViewController(_view.MockObject);
            _view.Expects.One.MethodWith(m => m.setDisplayText("123"));
            sut.setTextToDisplay("123");
            mockFactory.VerifyAllExpectationsHaveBeenMet();
        }

        [Test]
        public void ExpectsWithMoq()
        {
            var _view = new Moq.Mock<IMainView>();
            _view.Setup(_ => _.setDisplayText("123")).Verifiable();
            MainViewController sut = new MainViewController(_view.Object);
            sut.setTextToDisplay("123");
            _view.VerifyAll();
        }
    }
}
