using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSOD
{
    public class MainEntrance
    {
        public static void Main(string[] args)
        {
            TestValidBracketChecker();
            TestWeightedAverageCalculator();

            Console.ReadKey();
        }

        private static void TestValidBracketChecker()
        {
            var appPath = GetAppPath();

            for (int i = 1; i <= 5; i++)
            {
                var dataPath = "//CSOD.Test//TestData//Test" + i + ".txt";
                var filePath = appPath + dataPath;
                var checker = new ValidBracketChecker();
                try
                {
                    var sourceCode = File.ReadAllText(filePath);
                    Console.WriteLine("Input of Test{0} is:", i);
                    Console.WriteLine(sourceCode);
                    Console.WriteLine("The checking result for Test{0} is : {1}.", i, checker.ContainsValidBrackets(sourceCode));
                    Console.WriteLine();
                }
                catch (IOException e)
                {
                    Console.WriteLine("Read file error!" + e.Message);
                    return;
                }
            }
        }

        private static void TestWeightedAverageCalculator()
        {
            var scores = new List<WeightedScore>
            {
                new WeightedScore(7.3m, 0.3m),
                new WeightedScore(5.0m, 0.2m),
                new WeightedScore(7.7m, 0.4m),
                new WeightedScore(6.5m, 0.1m),
            };

            scores.ForEach(s => Console.Write("Score: {0} Weight: {1}, ", s.Score, s.Weight));
            var calculator = new WeightedAverageCalculator();
            Console.WriteLine("The weighted average is : {0}.", calculator.GetCalculatedAverage(scores));
        }

        private static string GetAppPath()
        {
            var separator = Path.DirectorySeparatorChar;
            var currentPath = AppDomain.CurrentDomain.BaseDirectory;
            var appPath = currentPath.Substring(0, currentPath.LastIndexOf(separator + "CSOD"));
            return appPath;
        }
    }
}
