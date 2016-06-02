using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lesson5;


namespace Tests
{
    [TestClass]
    public class IncreaseBalance
    {
        [TestMethod]
        public void IncreaseBalanceSuccses()
        {
            SavingsAccount saving = new SavingsAccount("12121", 100);

            saving.IncreaseBalance(200);
            decimal result = saving.Balance;

            Assert.AreEqual(300, Math.Abs(result));
        }
    }
}
