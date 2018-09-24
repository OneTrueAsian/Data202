using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LoanClass;
namespace LoanUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ClassLoan tmpl = new ClassLoan();
            tmpl.getInput("123", "Joey","R", 200000,50000,5,5);
            double lc = tmpl.Calculate();
            Assert.AreEqual(lc, 2830.69);
            double lc2 = tmpl.getTotali();
            Assert.AreEqual(lc2, 19841.10);
        }
    }
}
