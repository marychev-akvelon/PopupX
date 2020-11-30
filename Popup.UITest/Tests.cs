using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using System.Threading;

namespace Popup.UITest
{
    [TestFixture(Platform.Android)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void WelcomeTextIsDisplayed()
        {
            AppResult[] results = app.WaitForElement(c => c.Marked("Hello PopopX!"));
            app.Screenshot("Start PopopX");

            Assert.IsTrue(results.Any());

            Thread.Sleep(2000);
            app.Screenshot("Start to PRESS");
            app.Tap(c => c.Marked("I open POPUP for you!"));

            Thread.Sleep(2000);
            app.Screenshot("Want to see field Name");
            app.WaitForElement(c => c.Marked("Name:"));

        }
    }
}
