using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Data;

namespace SolveCaptcha
{
    public class Tests
    {
        
        [Test]
        public void Test1()
        {
            string url = "https://ultimateqa.com/filling-out-forms/";
            string userName = "Bob";
            string userMessage = "You will never be happier than you expect. To change your happiness, change your expectation.";
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));


            string nameFieldRight = "//input[contains(@id, 'et_pb_contact_name_1')]";
            string textAreaUserRight = "//textarea[@id='et_pb_contact_message_1']";

            IWebElement userNameField =  driver.FindElement(By.XPath(nameFieldRight));
            userNameField.Clear();
            userNameField.SendKeys(userName);
            

            IWebElement messageFromUser = driver.FindElement(By.XPath(textAreaUserRight));
            messageFromUser.Clear();
            messageFromUser.SendKeys(userMessage);

            
            string xpathCaptha = "(//span[@class='et_pb_contact_captcha_question'])[1]";
            string xpathCapthaResultField = "//input[@name='et_pb_contact_captcha_1']";
            
            IWebElement chaptaTExt = driver.FindElement(By.XPath(xpathCaptha));
            Console.WriteLine(chaptaTExt.Text);
            int result = CalculateExpression(chaptaTExt.Text);
            Console.WriteLine(result);

            IWebElement enterChaptaField = driver.FindElement(By.XPath(xpathCapthaResultField));
            enterChaptaField.Clear();
            enterChaptaField.SendKeys(result.ToString());

            string xpathButton = "(//button[@name='et_builder_submit_button'][normalize-space()='Submit'])[2]";
            IWebElement butonChapta = driver.FindElement(By.XPath(xpathButton));
            butonChapta.Click();

            //Thanks for contacting us
            string xpathMessageDisplayed = "//div[contains(@class, 'et-pb-contact-message')]//p[( \"Thanks for contacting us\")]";


            var condition = wait.Until(e => e.FindElement(By.XPath(xpathMessageDisplayed)));

            string messagee = condition.Text;
           Console.WriteLine(condition);
            string exceptedMessage = "Thanks for contacting us";

            Assert.IsTrue(exceptedMessage == messagee);
            
            driver.Quit();
        }

        private int CalculateExpression(string expression)
        {
            int resultValue;
            DataTable dataTable = new DataTable();
            object result = dataTable.Compute(expression, "");
            resultValue = Convert.ToInt32(result);
            return resultValue;
        }
    }
}
