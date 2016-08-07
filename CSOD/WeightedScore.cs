
namespace CSOD
{
   public class WeightedScore
    {
        // A decimal between 0.0 and 10.0 representing the score
        public decimal Score { get; set; }

        // A decimal between 0.0 and 1.0 representing the relative weight of the score
        public decimal Weight { get; set; }

        public WeightedScore (decimal score, decimal weight)
        {
            Score = score;
            Weight = weight;
        }

    }
}
