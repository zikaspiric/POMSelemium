using PageObjektModelTest.Helper;
using PageObjektModelTest.Page;

namespace PageObjektModelTest
{
    public class Tests:Base
    {
        PracticeForm form;

         [Test]
        public void Test1()
        {
            form = new PracticeForm();
            form.EnterFirstName("Zika");
            form.EnterLastName("Spiric");
            form.EntereMail("spiric@gmail.com");
           
            form.Mobile.SendKeys("251125");
            form.EnterSubject("Math");
            form.Subject.Click();
            form.Gender.Click();
            form.Hobbies.Click();
            form.Button.Submit();





        }
    }
}