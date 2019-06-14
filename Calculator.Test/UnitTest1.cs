﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Test
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Adding_4_And_3_Should_Return_7()
        {
            var calculator = new Calculator();
            int result = calculator.Add(4, 3);
            Assert.AreEqual(7, result);
        }
    }
}
