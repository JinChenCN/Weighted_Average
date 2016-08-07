using System;
using System.Collections.Generic;
using System.Linq;

namespace CSOD
{
    public class WeightedAverageCalculator
    {
        public decimal GetCalculatedAverage(List<WeightedScore> scores)
        {
            if (scores == null)
            {
                throw new Exception("Input is null!");
            }

            if (scores.Sum(s => s.Weight) > 1)
            {
                throw new Exception("Sum of weights can't be bigger than l!");
            }

            return scores.WeightedAverage(s => s.Score, s => s.Weight);
        }
    }
}
