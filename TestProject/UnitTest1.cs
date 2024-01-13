using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject
{
    public class Tests
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://localhost:7279");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void Calculate_Addition()
        {
            IWebElement number1Input = driver.FindElement(By.Id("number1"));
            IWebElement number2Input = driver.FindElement(By.Id("number2"));
            IWebElement calculateButton = driver.FindElement(By.Id("calculateButton"));
            IWebElement resultElement = driver.FindElement(By.Id("result"));

            number1Input.SendKeys("5");
            number2Input.SendKeys("7");
            calculateButton.Click();

            string result = resultElement.Text;
            Assert.AreEqual("Result: 12", result);
        }
    }
}