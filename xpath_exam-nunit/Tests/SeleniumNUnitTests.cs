using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xpath_exam_nunit.Tests
{
    public class SeleniumNUnitTests
    {
        [Test]
        public void ElementLocatorRadioTest()
        {
            IWebDriver driver = new ChromeDriver();

            string URL = "https://ultimateqa.com/simple-html-elements-for-automation/";
            
            driver.Navigate().GoToUrl(URL);
            // Exercise: Navigate to a webpage containing a radio button group.
            // Find the radio button with the value 'male', click on it, and check if it becomes selected.


            string xpathMale = "//input[contains(@value, 'male')]";
            IWebElement radiuButonMale = driver.FindElement(By.XPath(xpathMale));
            radiuButonMale.Click();

            Assert.IsTrue(radiuButonMale.Selected);

            driver.Quit();
        }

        [Test]
        public void ElementLocatorCheckboxTest() 
        {
            IWebDriver driver = new ChromeDriver();
            string URL = "https://ultimateqa.com/simple-html-elements-for-automation/";

            driver.Navigate().GoToUrl(URL);
            // Exercise: Navigate to a webpage containing a checkbox.
            // Find the checkbox with the value 'I have a car', click on it, and check if it becomes selected.

            string xpathCheckbox = "//input[@type='checkbox' and @value='Car']";

            IWebElement checkboxCar = driver.FindElement(By.XPath(xpathCheckbox));

            
            checkboxCar.Click();

            Assert.IsTrue(checkboxCar.Selected);

            driver.Quit();

        }

        [Test]
        public void ElementLocatorDropdownTest() 
        {
            IWebDriver driver = new ChromeDriver();
            string URL = "https://ultimateqa.com/simple-html-elements-for-automation/";
            driver.Navigate().GoToUrl(URL);
            // Exercise: Navigate to a webpage containing a dropdown.
            // Find the dropdown with the value 'Audi', click on it, and check if it becomes selected.

            string xpathDropdown = "//option[contains(@value, 'audi')]";

            IWebElement dropdownAudi = driver.FindElement(By.XPath(xpathDropdown));
            dropdownAudi.Click();

            // Execute JavaScript code to apply a red border around the element

            Assert.IsTrue(dropdownAudi.Selected);
            driver.Quit();

        }

        // xpath for highlightMe = "//div[contains(@class, 'et_pb_module et_pb_blurb et_pb_blurb_15  et_pb_text_align_left  et_pb_blurb_position_top et_pb_bg_layout_light')]//..//span[contains(text(), 'Highlight me')]"

        [Test]
        public void ElementLocatorHiglightMeTest() 
        {
            IWebDriver driver= new ChromeDriver();
            string URL = "https://ultimateqa.com/simple-html-elements-for-automation/";
            driver.Navigate().GoToUrl(URL);

            string xpathHighlightMe = "//div[contains(@class, 'et_pb_module et_pb_blurb et_pb_blurb_15  et_pb_text_align_left  et_pb_blurb_position_top et_pb_bg_layout_light')]//..//span[contains(text(), 'Highlight me')]";

            IWebElement locateText = driver.FindElement(By.XPath(xpathHighlightMe));
            Console.WriteLine(locateText.Text);
            
            Assert.AreEqual("Highlight me", locateText.Text);
            driver.Quit();


        }

    }
}
