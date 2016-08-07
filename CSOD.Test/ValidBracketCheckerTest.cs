using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace CSOD.Test
{
    [TestClass]
    public class ValidBracketCheckerTest
    {
        ValidBracketChecker checker = new ValidBracketChecker();

        [TestMethod]
        public void ValidBracket()
        {
            ExecuteTest("TestData\\Test1.txt", true);
        }

        [TestMethod]
        public void RedundantLeftBracket()
        {
            ExecuteTest("TestData\\Test2.txt", false);
        }

        private void ExecuteTest(string testData, bool expected)
        {
            try
            {
                var sourceCode = File.ReadAllText(testData);
                Assert.AreEqual(expected, checker.ContainsValidBrackets(sourceCode));
            }
            catch (IOException e)
            {
                Console.WriteLine("Read file error!" + e.Message);
                return;
            }
        }
    }
}
