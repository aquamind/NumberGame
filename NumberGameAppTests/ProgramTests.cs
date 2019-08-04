using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberGameApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGameApp.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void FivaTimesWinTest()
        {
            var input = new StringBuilder();
            input.AppendLine("2019");
            input.AppendLine("1234");
            input.AppendLine("5678");
            input.AppendLine("0912");
            input.AppendLine("2190");
            input.AppendLine("2019");
            var output = new StringBuilder();
            output.AppendLine("0 2");
            output.AppendLine("0 0");
            output.AppendLine("1 3");
            output.AppendLine("1 3");
            output.AppendLine("4 0");
            output.AppendLine("win");

            Assert.AreEqual(output.ToString(), GetResult(input));
        }

        [TestMethod()]
        public void LoseTest()
        {
            var input = new StringBuilder();
            input.AppendLine("7382");
            input.AppendLine("0123");
            input.AppendLine("4567");
            input.AppendLine("2389");
            input.AppendLine("2459");
            input.AppendLine("9387");
            var output = new StringBuilder();
            output.AppendLine("0 2");
            output.AppendLine("0 1");
            output.AppendLine("2 1");
            output.AppendLine("0 1");
            output.AppendLine("2 1");
            output.AppendLine("lose");

            Assert.AreEqual(output.ToString(), GetResult(input));
        }

        [TestMethod()]
        public void OneTimeWinTest()
        {
            var input = new StringBuilder();
            input.AppendLine("1234");
            input.AppendLine("1234");
            input.AppendLine("1234");
            input.AppendLine("1234");
            input.AppendLine("1234");
            input.AppendLine("1234");
            var output = new StringBuilder();
            output.AppendLine("4 0");
            output.AppendLine("win");

            Assert.AreEqual(output.ToString(), GetResult(input));
        }

        private static string GetResult(StringBuilder input)
        {
            var sr = new System.IO.StringReader(input.ToString());
            var sw = new System.IO.StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);
            Program.Main(new string[0]);

            return sw.GetStringBuilder().ToString();
        }
    }
}