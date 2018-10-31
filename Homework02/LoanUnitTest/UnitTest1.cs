using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using LoanClass;

namespace LoanUnitTest

{

    [TestClass]

    public class UnitTest1

    {

        [TestMethod]

        public void TestMethodInit()

        {

            /// <summary>

            /// Testing Refinance Test

            /// R + 0

            /// </summary>



            ClassLoan tmpl = new ClassLoan();

            tmpl.getInput("123", "Joey", "R", 200000, 50000, 5, 5);

            double lc = tmpl.Calculate();

            Assert.AreEqual(lc, 2830.69);

            double lc2 = tmpl.getTotali();

            Assert.AreEqual(lc2, 19841.10);



            ClassLoan tmpl2 = new ClassLoan();

            tmpl2.getInput("123", "Joey", "R", 250000, 50000, 5, 6);

            double lc3 = tmpl2.Calculate();

            Assert.AreEqual(lc3, 3866.56);

            double lc4 = tmpl2.getTotali();

            Assert.AreEqual(lc4, 31993.62);

        }



        [TestMethod]

        public void TestMethodAuto()

        {

            /// <summary>

            /// testing Auto Loan

            /// R + 3.5

            /// </summary>



            ClassLoan tmpl1 = new ClassLoan();

            tmpl1.getInput("321", "Bob", "A", 200000, 50000, 5, 5);

            double lc = tmpl1.Calculate();

            Assert.AreEqual(lc, 3077.48);

            double lc2 = tmpl1.getTotali();

            Assert.AreEqual(lc2, 34648.78);



            ClassLoan tmpl2 = new ClassLoan();

            tmpl2.getInput("123", "Joey", "A", 250000, 50000, 5, 6);

            double lc3 = tmpl2.Calculate();

            Assert.AreEqual(lc3, 4200.37);

            double lc4 = tmpl2.getTotali();

            Assert.AreEqual(lc4, 52022.34);

        }



        [TestMethod]

        public void TestMethodEquity()

        {

            /// <summary>

            /// Testing Home Equity

            /// R + 2.5

            /// </summary>

            ClassLoan tmpl1 = new ClassLoan();

            tmpl1.getInput("321", "Bob", "E", 200000, 50000, 5, 5);

            double lc1 = tmpl1.Calculate();

            Assert.AreEqual(lc1, 3005.69);

            double lc2 = tmpl1.getTotali();

            Assert.AreEqual(lc2, 30341.54);



            ClassLoan tmpl2 = new ClassLoan();

            tmpl2.getInput("123", "Joey", "E", 250000, 50000, 5, 6);

            double lc3 = tmpl2.Calculate();

            Assert.AreEqual(lc3, 4103.31);

            double lc4 = tmpl2.getTotali();

            Assert.AreEqual(lc4, 46198.38);

        }



        [TestMethod]

        public void TestBusiness()

        {

            /// <summary>

            /// Testing Business Test

            /// R + .5

            /// </summary>

            ClassLoan tmpl = new ClassLoan();

            tmpl.getInput("123", "Joey", "B", 200000, 50000, 5, 5);

            double lc = tmpl.Calculate();

            Assert.AreEqual(lc, 2865.17);

            double lc2 = tmpl.getTotali();

            Assert.AreEqual(lc2, 21910.46);



            ClassLoan tmpl2 = new ClassLoan();

            tmpl2.getInput("123", "Joey", "B", 250000, 50000, 5, 5);

            double lc3 = tmpl2.Calculate();

            Assert.AreEqual(lc3, 3820.23);

            double lc4 = tmpl2.getTotali();

            Assert.AreEqual(lc4, 29213.95);

        }



        [TestMethod]

        public void TestMethodHome()

        {

            /// <summary>

            /// Testing Home Loan Test

            /// R + 1

            /// </summary>

            ClassLoan tmpl = new ClassLoan();

            tmpl.getInput("123", "Joey", "H", 200000, 50000, 5, 5);

            double lc = tmpl.Calculate();

            Assert.AreEqual(lc, 2899.92);

            double lc2 = tmpl.getTotali();

            Assert.AreEqual(lc2, 23995.21);



            ClassLoan tmpl2 = new ClassLoan();

            tmpl2.getInput("123", "Joey", "H", 250000, 50000, 5, 6);

            double lc3 = tmpl2.Calculate();

            Assert.AreEqual(lc3, 3960.24);

            double lc4 = tmpl2.getTotali();

            Assert.AreEqual(lc4, 37614.38);

        }



        [TestMethod]

        public void TestString()

        {

            /// <summary>

            /// Testing Names and SSN

            /// Tests getName, getSSN, getChoice

            /// </summary>

            ClassLoan tmp1 = new ClassLoan();

            tmp1.getInput("000-00-0000", "Dave", "R", 200000, 50000, 5, 5);

            string lc1 = tmp1.getName();

            string lc2 = tmp1.getSSN();

            string lc3 = tmp1.getChoice();

            Assert.AreEqual(lc1, "Dave");

            Assert.AreEqual(lc2, "000-00-0000");

            Assert.AreEqual(lc3, "R");



            ClassLoan tmp2 = new ClassLoan();

            tmp2.getInput("002-10-0400", "Joey", "E", 200000, 50000, 5, 5);

            string lc4 = tmp2.getName();

            string lc5 = tmp2.getSSN();

            string lc6 = tmp2.getChoice();

            Assert.AreEqual(lc4, "Joey");

            Assert.AreEqual(lc5, "002-10-0400");

            Assert.AreEqual(lc6, "E");

        }

        public void TestDoubles()

        {

            /// <summary>

            /// test getLoan, getDownPayment, getRate, getTime

            /// </summary>

            ClassLoan tmpl1 = new ClassLoan();

            tmpl1.getInput("321", "Bob", "E", 200000, 50000, 5, 5);

            tmpl1.Calculate();

            double lc = tmpl1.getDownPayment();

            double lc1 = tmpl1.getLoan();

            double lc2 = tmpl1.getRate();

            double lc3 = tmpl1.getTime();



            Assert.AreEqual(lc, 50000);

            Assert.AreEqual(lc1, 1500000);

            Assert.AreEqual(lc2, 5);

            Assert.AreEqual(lc3, 5);



            ClassLoan tmpl2 = new ClassLoan();

            tmpl2.getInput("321", "Bob", "E", 300000, 25000, 7, 9);

            tmpl2.Calculate();

            double lc4 = tmpl2.getDownPayment();

            double lc5 = tmpl2.getLoan();

            double lc6 = tmpl2.getRate();

            double lc7 = tmpl2.getTime();



            Assert.AreEqual(lc4, 25000);

            Assert.AreEqual(lc5, 275000);

            Assert.AreEqual(lc6, 9);

            Assert.AreEqual(lc7, 7);



        }

    }

}