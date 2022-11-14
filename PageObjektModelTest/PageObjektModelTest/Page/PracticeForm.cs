

using OpenQA.Selenium;
using PageObjektModelTest.Driver;
using WebDriver = PageObjektModelTest.Driver.WebDriver;

namespace PageObjektModelTest.Page
{
    public class PracticeForm
    {

        private IWebDriver driver = WebDriver.Instance;

        public IWebElement FirstName => driver.FindElement(By.Id("firstName"));

        public IWebElement LastName => driver.FindElement(By.Id("lastName"));

        public IWebElement eMail => driver.FindElement(By.Id("userEmail"));

        public IWebElement Gender => driver.FindElement(By.Id("gender-radio-1"));

        public IWebElement Mobile => driver.FindElement(By.Id("userNumber"));


        public IWebElement Subject => driver.FindElement(By.Id("subjectsContainer"));

        public IWebElement Hobbies => driver.FindElement(By.Id("hobbies-checkbox-1"));

        public IWebElement Button => driver.FindElement(By.Id("submit"));


        
        public void EnterFirstName(string firstname)
        {
            FirstName.SendKeys(firstname);
        }
        public void EnterLastName(string lastname)
        {
            LastName.SendKeys(lastname);
        }
        public void EntereMail(string email)
        {
            eMail.SendKeys(email);

        }
        public void SelectGender()
        {
            Gender();
        }
        public void EnterMobile(string mobile)
        {
            Mobile.SendKeys(mobile);
        }
        public void EnterSubject(string sub)
        {
            Subject.SendKeys(sub);
        }
        public void SelectHobbies()
        {
            Hobbies.Click();
        }

        public void PressButton()
        {
            Button.
        }
        

    }
        
}
