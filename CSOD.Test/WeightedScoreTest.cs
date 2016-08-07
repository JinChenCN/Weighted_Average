using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSOD.Test
{
    [TestClass]
    public class WeightedScoreTest
    {
        WeightedAverageCalculator calculator = new WeightedAverageCalculator();

        [TestMethod]
        public void GetCalculatedAverageValidInput()
        {
            var scores = new List<WeightedScore>
            {
                new WeightedScore(7.3m, 0.3m),
                new WeightedScore(5.0m, 0.2m),
                new WeightedScore(7.7m, 0.4m),
                new WeightedScore(6.5m, 0.1m),
            };
            decimal expected = (7.3m * 0.3m + 5.0m * 0.2m + 7.7m * 0.4m + 6.5m * 0.1m) / (0.3m + 0.2M + 0.4m + 0.1m);
            Assert.AreEqual(expected, calculator.GetCalculatedAverage(scores));
        }

    }
}
