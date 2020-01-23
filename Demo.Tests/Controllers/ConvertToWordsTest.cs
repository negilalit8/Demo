using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Demo;
using Demo.Controllers;
using DemoModal;
using BAL;

namespace Demo.Tests.Controllers
{
    [TestClass]
    public class ConvertToWordsTest
    {
        private IValueBAL _IvalueBAL;

        public ConvertToWordsTest(IValueBAL IvalueBAL)
        {
            _IvalueBAL = IvalueBAL;
        }
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange        
            ConvertToWordsController controller = new ConvertToWordsController(_IvalueBAL);
            ValuesModal obj = new ValuesModal();
            obj.name = "Lalit";
            obj.amount = "123.34";

            // Act
            string result = controller.Get(obj);

            // Assert
            Assert.IsNotNull(result);         
            Assert.AreEqual("Lalit One Hundred Twenty Three  Dollars And  Three Four Cents ", result);
        }
    }
}
