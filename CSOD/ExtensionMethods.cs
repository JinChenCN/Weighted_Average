using System;
using System.Collections.Generic;
using System.Linq;

namespace CSOD
{
    public static class ExtensionMethods
    {
        public static decimal WeightedAverage<T>(this IEnumerable<T> scores, Func<T, decimal> value, Func<T, decimal> weight) where T : WeightedScore
        {
            decimal weightedValueSum = scores.Sum(s => value(s) * weight(s));
            decimal weightSum = scores.Sum(s => weight(s));

            if (weightSum != 0)
                return weightedValueSum / weightSum;
            else
                throw new DivideByZeroException("Invalid weight!");
        }
    }
}
