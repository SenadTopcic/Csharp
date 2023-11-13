using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NavigationSeleniumDriver
{
    [TestClass]
    public class NavigationQuiz
    {
        [TestMethod]
        public void TestMethod1()
        {
            string url = "https://ultimateqa.com/ ";
            string expected = "Homepage - Ultimate QA";
            string actual = string.Empty;
            
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
            actual = driver.Title;
            Console.WriteLine(actual);

            Assert.AreEqual(expected, actual);
            driver.Quit();
        }

        [TestMethod]
        public void TestMethod2()
        {
            string url = "https://ultimateqa.com/automation/";
            string expected = "Automation Practice - Ultimate QA";
            string actual = string.Empty;

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
            actual = driver.Title;
            
            Assert.AreEqual(expected, actual);
            driver.Quit();
        }

        [TestMethod]
        public void TestMethod3()
        {
            string url = "https://ultimateqa.com/automation/";
            string expected1 = "Complicated Page - Ultimate QA";
            string expected2 = "Automation Practice - Ultimate QA";
            string actual = string.Empty;

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
            string xpathLink = "//a[contains(@href, '../complicated-page')]";
            IWebElement locatorLink = driver.FindElement(By.XPath(xpathLink));
            locatorLink.Click();
            actual = driver.Title;
            Console.WriteLine(actual);
            Assert.AreEqual(expected1, actual);
            driver.Navigate().Back();
            actual = driver.Title;
            Assert.AreEqual (expected2, actual);

            driver.Quit();
        }
    }
}