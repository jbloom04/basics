using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace basics.Test
{
    [TestClass]
    public class SimpleOperationTest//each test class is associated to a class
    {
        [TestMethod]
        public void Operate_DoAdd_ReturnsSum()//naming convention - arrange,act,assert
        {
            //Arrange
            SimpleOperation sp = new SimpleOperation();
            int x = 1;
            int a = 5;
            int b = 7;
            //Act
            int result = sp.operate(x, a, b);
            //Assert
            Assert.AreEqual(12, result);
        }

        [TestMethod]
        public void Operate_DoSubtract_ReturnsSubtraction()
        {
            //Arrange
            SimpleOperation sp = new SimpleOperation();
            int x = 2;
            int a = 5;
            int b = 7;
            //Act
            int result = sp.operate(x, a, b);
            //Assert
            Assert.AreEqual(-2, result);
        }

        [TestMethod]
        public void Operate_DoDefaultParameter_ReturnsZero()
        {
            //Arrange
            SimpleOperation sp = new SimpleOperation();
            int x = 3;
            int a = 5;
            int b = 7;
            //Act
            int result = sp.operate(x, a, b);
            //Assert
            Assert.AreEqual(0, result);
        }
    }
}
