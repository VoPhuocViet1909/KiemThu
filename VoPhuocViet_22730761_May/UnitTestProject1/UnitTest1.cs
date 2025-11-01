using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VoPhuocViet_22730761_May;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }
        private Class1 triangle = new Class1();

        [DataSource(
            "Microsoft.VisualStudio.TestTools.DataSource.CSV",
            "|DataDirectory|\\data.csv",
            "data#csv",
            DataAccessMethod.Sequential),
         DeploymentItem("data.csv"),
         TestMethod]
        public void CheckTriangle_DataDrivenTest()
        {
            // Đọc dữ liệu từ file CSV
            int a = int.Parse(TestContext.DataRow[0].ToString());
            int b = int.Parse(TestContext.DataRow[1].ToString());
            int c = int.Parse(TestContext.DataRow[2].ToString());
            string expected = TestContext.DataRow[3].ToString();

            // Nếu dòng dữ liệu có expected = "Exception" → kiểm tra ném Exception
            if (expected == "Exception")
            {
                Assert.ThrowsException<Exception>(() =>
                {
                    triangle.CheckTriangle(a, b, c);
                });
            }
            else
            {
                bool actual = triangle.CheckTriangle(a, b, c);
                bool expectedBool = bool.Parse(expected);
                Assert.AreEqual(expectedBool, actual);
            }
        }

    }
}
