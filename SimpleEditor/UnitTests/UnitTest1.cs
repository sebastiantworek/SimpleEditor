using System;
using DataModel.Elements;
using DrawingEngine;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        private const string JSON = "{type: \"line\" }";
        [TestMethod]
        public void DataConverterTest()
        {
            DataConverter converter = new DataConverter();
            var obj = converter.ReadFromJson(JSON);

            Assert.IsTrue(obj is Line);
        }
    }
}
