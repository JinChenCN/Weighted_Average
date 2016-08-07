using System;
using System.Collections.Generic;

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

            return scores.WeightedAverage(s => s.Score, s => s.Weight);
        }
    }
}
