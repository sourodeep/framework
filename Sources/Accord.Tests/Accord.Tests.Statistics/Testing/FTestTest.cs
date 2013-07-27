﻿

namespace Accord.Tests.Statistics
{
    using Accord.Statistics.Testing;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    
    [TestClass()]
    public class FTestTest
    {


        private TestContext testContextInstance;

        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        [TestMethod()]
        public void FTestConstructorTest()
        {
            double var1 = 1.05766555271071; 
            double var2 = 1.16570834301777; 
            int d1 = 49;
            int d2 = 49;

            FTest oneGreater = new FTest(var1, var2, d1, d2, TwoSampleHypothesis.FirstValueIsGreaterThanSecond);
            FTest oneSmaller = new FTest(var1, var2, d1, d2, TwoSampleHypothesis.FirstValueIsSmallerThanSecond);
            FTest twoTail = new FTest(var1, var2, d1, d2, TwoSampleHypothesis.ValuesAreDifferent);

            Assert.AreEqual(0.632, oneGreater.PValue, 1e-3);
            Assert.AreEqual(0.367, oneSmaller.PValue, 1e-3);
            Assert.AreEqual(0.734, twoTail.PValue, 1e-3);

            Assert.IsFalse(Double.IsNaN(oneGreater.PValue));
            Assert.IsFalse(Double.IsNaN(oneSmaller.PValue));
            Assert.IsFalse(Double.IsNaN(twoTail.PValue));

        }
    }
}
