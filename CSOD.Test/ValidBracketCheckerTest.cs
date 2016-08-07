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
        [ExpectedException(typeof(Exception))]
        public void InputNullException()
        {
            checker.ContainsValidBrackets(null);
        }

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

        [TestMethod]
        public void RedundantRightBracket()
        {
            ExecuteTest("TestData\\Test3.txt", false);
        }

        [TestMethod]
        public void UnbalancedBracket()
        {
            ExecuteTest("TestData\\Test4.txt", false);
        }

        [TestMethod]
        public void InputEmpty()
        {
            ExecuteTest("TestData\\Test5.txt", true);
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
