using Microsoft.VisualStudio.TestTools.UnitTesting;
using VoPhuocViet_22730761_May;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoPhuocViet_22730761_May.Tests
{
    [TestClass()]
    public class CheckTriangleTest
    {
        private Class1 triangle = new Class1();

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TC1_CanhAm_ThrowException()
        {
            triangle.CheckTriangle(0, 1, 2);
        }

        [TestMethod()]
        public void CheckTriangleTest1()
        {
            bool expected = false;
            bool actual = triangle.CheckTriangle(1, 2, 5);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CheckTriangleTest2()
        {
            bool expected = false;
            bool actual = triangle.CheckTriangle(5,1,2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CheckTriangleTest3()
        {
            bool expected = false;
            bool actual = triangle.CheckTriangle(1,5,2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CheckTriangleTest4()
        {
            bool expected = true;
            bool actual = triangle.CheckTriangle(3,4,5);
            Assert.AreEqual(expected, actual);
        }


    }
}