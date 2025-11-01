using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class CheckTriangleTests
    {

        public bool CheckTriangle(int a, int b, int c)
        {
            bool result;

            // Ném Exception nếu có cạnh ≤ 0
            if (a <= 0 || b <= 0 || c <= 0)
                throw new Exception("Cạnh không được nhỏ hơn hoặc bằng 0!");

            // Kiểm tra điều kiện tam giác
            if (a + b > c)
                if (a + c > b)
                    if (b + c > a)
                        result = true;
                    else
                        result = false;
                else
                    result = false;
            else
                result = false;

            return result;
        }

        [TestMethod]
        public void TC1_CanhAm_ThrowException()
        {
            // ném Exception
            Assert.ThrowsException<Exception>(() =>
            {
                CheckTriangle(-3, 4, 5);
            });
        }

        [TestMethod]
        public void TC2_AB_NhoHonHoacBangC_ReturnFalse()
        {
            bool expected = false;
            bool actual = CheckTriangle(2, 3, 6);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TC3_AC_NhoHonHoacBangB_ReturnFalse()
        {
            bool expected = false;
            bool actual = CheckTriangle(2, 8, 5);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TC4_BC_NhoHonHoacBangA_ReturnFalse()
        {
            bool expected = false;
            bool actual = CheckTriangle(9, 2, 6);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TC5_TamGiacHopLe_ReturnTrue()
        {
            bool expected = true;
            bool actual = CheckTriangle(3, 4, 5);
            Assert.AreEqual(expected, actual);
        }
    }
}
