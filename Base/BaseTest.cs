using OpenQA.Selenium;
using Pra7.Drivers;

namespace Pra7.Base
{
    public class BaseTest
    {
        protected IWebDriver driver;

        //The setup method runs before each test (or test suite) to prepare the environment
        //1.Driver Initialization: 2.Browser Configuration: 3.Navigation: 4.Framework Attributes: 
        [SetUp]
        public void SetUp()
        {
            driver = DriverFactory.InitDriver();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        //The teardown method runs after each test concludes, regardless of whether the test passed or failed.
        //1.Cleanup Actions: 2.Post-Test Data: 3.Artifact Collection: Capture screenshots or logs 4.Framework Attributes:
        [TearDown]
        public void TearDown()
        {
            //driver.Dispose();
            //driver.Quit();
            //The driver.close() method is used to close the current browser window which is in focus for WebDriver.
            // driver.Dispose() .NET to release memory and resources associated with the WebDriver 
            //driver.quit() method is used to close all browser windows which are running and it will end the webdriver session.

            /*
             *         
            public static void Capture(IWebDriver driver)
            {
                var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                screenshot.SaveAsFile($"screenshoot_{DateTime.Now.Ticks}.png");

            }
             */



            try
            {
                var testStatus = TestContext.CurrentContext.Result.Outcome.Status;
                if (testStatus == NUnit.Framework.Interfaces.TestStatus.Failed)
                {
                    //var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                    //screenshot.SaveAsFile($"screenshoot_{DateTime.Now.Ticks}.png");

                    var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                    var fileName = $"Screenshot_{TestContext.CurrentContext.Test.Name}_{DateTime.Now:yyyyMMdd_HHmmss}.png";
                    var filePath = Path.Combine(TestContext.CurrentContext.WorkDirectory, fileName);
                    screenshot.SaveAsFile(filePath);

                    TestContext.AddTestAttachment(filePath);
                }
            }
            catch (Exception)
            {
                // Ignore screenshot errors
            }
            finally
            {
                driver.Dispose();
                driver.Quit();
            }
        }
    }
}
