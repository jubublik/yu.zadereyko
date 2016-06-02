using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lesson5;

namespace Tests
{
    [TestClass]
    public class DecreaseBalance
    {
        [TestMethod]
        public void DecreaseBalanceSuccses()
        {
            SavingsAccount saving = new SavingsAccount("12121", 400);

            saving.DecreaseBalance(150);
            decimal result = saving.Balance;

            Assert.AreEqual(250, Math.Abs(result));
        }
        public void DecreaseBalanceFailed()
        {
            SavingsAccount saving = new SavingsAccount("12121", 400);

            saving.DecreaseBalance(450);

            Assert.Fail();
        }
    }
}
