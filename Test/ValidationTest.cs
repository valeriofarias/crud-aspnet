﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class ValidationTest
    {
        [TestMethod]
        public void TestCPFValidationForOnlyNumbers()
        {
            Assert.AreEqual(true, Bll.Components.Validation.CPFValidate("06948578403"));
        }

        [TestMethod]
        public void TestCPFValidationForNumbersWithDotAndDash()
        {
            Assert.AreEqual(true, Bll.Components.Validation.CPFValidate("069.485.784-03"));
        }

        [TestMethod]
        public void TestCPFValidationForNumbersWithDot()
        {
            Assert.AreEqual(true, Bll.Components.Validation.CPFValidate("069.485.784.03"));
        }

        [TestMethod]
        public void TestCPFValidationForNumbersWithDash()
        {
            Assert.AreEqual(true, Bll.Components.Validation.CPFValidate("069-485-784-03"));
        }

        [TestMethod]
        public void TestCPFValidationForNumbersOnlyInvalid()
        {
            Assert.AreEqual(false, Bll.Components.Validation.CPFValidate("06784458775"));
        }

        [TestMethod]
        public void TestCPFValidationForNumbersWithDotAndDashInvalid()
        {
            Assert.AreEqual(false, Bll.Components.Validation.CPFValidate("067.844.587-75"));
        }

        [TestMethod]
        public void TestCPFValidationForNumbersWithDotInvalid()
        {
            Assert.AreEqual(false, Bll.Components.Validation.CPFValidate("067.844.587.75"));
        }

        [TestMethod]
        public void TestCPFValidationForNumbersWithDashInvalid()
        {
            Assert.AreEqual(false, Bll.Components.Validation.CPFValidate("067-844-587-75"));
        }
    }
}
