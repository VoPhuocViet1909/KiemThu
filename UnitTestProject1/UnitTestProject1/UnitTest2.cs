using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest2
    {
        public TestContext TestContext { get; set; }

        [DataSource(
            "Microsoft.VisualStudio.TestTools.DataSource.CSV",
            "|DataDirectory|\\data.csv",
            "data#csv",
            DataAccessMethod.Sequential),
         DeploymentItem("data.csv"),
         TestMethod]

        public void CheckTriangle_DataDriven_CSV()
        {

            int a = Convert.ToInt32(TestContext.DataRow[0]);
            int b = Convert.ToInt32(TestContext.DataRow[1]);
            int c = Convert.ToInt32(TestContext.DataRow[2]);
            string expected = TestContext.DataRow[3].ToString();

            if (expected == "Exception")
            {
                Assert.ThrowsException<Exception>(() =>
                {
                    CheckTriangle(a, b, c);
                });
            }
            else
            {
                bool exp = bool.Parse(expected);
                bool actual = CheckTriangle(a, b, c);
                Assert.AreEqual(exp, actual);
            }
        }

        // Viết hàm đề cho
        private bool CheckTriangle(int a, int b, int c)
        {
            bool result;
            if (a <= 0 || b <= 0 || c <= 0)
                return false;
            if (a + b > c)
                if (a + c > b)
                    if (b + c > a)
                        result = true;
                    else
                        result = false;
                else
                    result = false;
            else
                result = true;

            return result;
        }
    }
}
