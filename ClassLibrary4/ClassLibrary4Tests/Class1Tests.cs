using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary4.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        
        private Class1 triangle = new Class1(); // class chứa hàm CheckTriangle

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TC1_CanhAm_ThrowException()
        {
            triangle.CheckTriangle(-3, 4, 5);
        }

        [TestMethod]
        public void TC2_AB_NhoHonHoacBangC_ReturnFalse()
        {
            bool expected = false;
            bool actual = triangle.CheckTriangle(2, 3, 6);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TC3_AC_NhoHonHoacBangB_ReturnFalse()
        {
            bool expected = false;
            bool actual = triangle.CheckTriangle(2, 8, 5);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TC4_BC_NhoHonHoacBangA_ReturnFalse()
        {
            bool expected = false;
            bool actual = triangle.CheckTriangle(9, 2, 6);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TC5_TamGiacHopLe_ReturnTrue()
        {
            bool expected = true;
            bool actual = triangle.CheckTriangle(3, 4, 5);
            Assert.AreEqual(expected, actual);
        }
    }
}