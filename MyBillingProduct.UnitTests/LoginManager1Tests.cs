using NUnit.Framework;

namespace MyBillingProduct.UnitTests
{
    public class LoginManager1Tests
    {
        [Test]
        public void FirstTest()
        {
            LoginManager1 lm = new LoginManager1();
            lm.AddUser("a", "pass");
           //? 
        }
    }
}