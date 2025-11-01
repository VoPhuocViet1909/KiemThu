using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary5.Tests
{
    [TestClass()]
    public class KiemTraTamGiacTests
    {
       

        [TestMethod]
        public void TC1_CanhKhongHopLe_ReturnEmpty()
        {
            string expected = "";
            string actual = Class1.KiemTraTamGiac(0, 4, 5);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TC2_TamGiacDeu()
        {
            string expected = "Tam_giac_deu";
            string actual = Class1.KiemTraTamGiac(3, 3, 3);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TC3_TamGiacCan()
        {
            string expected = "am_giac_can";
            string actual = Class1.KiemTraTamGiac(4, 4, 5);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TC4_TamGiacVuongCan()
        {
            string expected = "Tam_giac_vuong_can";
            string actual = Class1.KiemTraTamGiac(5, 5, 7);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TC5_TamGiacVuong()
        {
            string expected = "Tam_giac_vuong";
            string actual = Class1.KiemTraTamGiac(3, 4, 5);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TC6_TamGiacThuong()
        {
            string expected = "Tam_giac_thuong";
            string actual = Class1.KiemTraTamGiac(4, 5, 6);
            Assert.AreEqual(expected, actual);
        }
    }
}