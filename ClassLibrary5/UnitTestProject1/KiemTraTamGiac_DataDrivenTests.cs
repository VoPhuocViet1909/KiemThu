using System;
using ClassLibrary5;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class KiemTraTamGiac_DataDrivenTests
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource(
            "Microsoft.VisualStudio.TestTools.DataSource.CSV",
            "|DataDirectory|\\data.csv",
            "data#csv",
            DataAccessMethod.Sequential)]
        [DeploymentItem("data.csv")]
        public void TestKiemTraTamGiac_DataDriven()
        {
            // Đọc dữ liệu từ file CSV
            int a = int.Parse(TestContext.DataRow[0].ToString());
            int b = int.Parse(TestContext.DataRow[1].ToString());
            int c = int.Parse(TestContext.DataRow[2].ToString());
            string expected = TestContext.DataRow[3].ToString();

            // Gọi hàm cần test
            string actual = Class1.KiemTraTamGiac(a, b, c);

            Assert.AreEqual(
                 expected?.Trim(),
                 actual?.Trim(),
                 $" Input: ({a},{b},{c}) => Expected: \"{expected}\", Actual: \"{actual}\""
             );
        }
    }
}
