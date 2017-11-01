using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;
using TransformationLib;

namespace TransformationTestsLib
{
    [TestClass]
    public class TransformationTests
    {
        [TestMethod]
        public void OneTimeRow()
        {
            var amountContent = "12.50\r\n17.50";
            var quantityContent = "2\r\n10";
            var actual = Transformation.Transform(amountContent, quantityContent);
            var expected = "12.50x2=25.00\r\n12.50x10=125.00\r\n17.50x2=35.00\r\n17.50x10=175.00";
            Assert.AreEqual(expected, actual);

        }
    }
}
