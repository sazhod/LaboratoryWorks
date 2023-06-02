using lab6_dll;
using System.Security.Principal;
using Xunit.Sdk;

namespace lab6_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCreateAcccount()
        {
            string customer = "Каюмов Сажод";
            double balance = 1000;
            BankAccount account = new BankAccount(customer, balance);
            Assert.AreEqual(account.Customer, customer);
            Assert.AreEqual(account.Balance, balance);
        }
        [TestMethod]
        public void TestCredit()
        {
            string customer = "Каюмов Сажод";
            double balance = 1000;
            BankAccount account = new BankAccount(customer, balance);
            double delta = 0.01;
            double amount = 50.33;
            double actualResult = 1050.33;
            account.Credit(amount);
            double result = account.Balance;
            Assert.AreEqual(actualResult, result, delta);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestCreditWithAmountLessThanZero()
        {
            string customer = "Каюмов Сажод";
            double balance = 1000;
            BankAccount account = new BankAccount(customer, balance);
            double amount = -50.33;
            account.Credit(amount);
        }
    }
}