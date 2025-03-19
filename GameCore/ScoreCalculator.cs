using System.Collections.Generic;
using System.Linq;

namespace GameCore
{
    public static class ScoreCalculator
    {
        public static int CalculateScore(Hand hand)
        {
            var score = 0;

            // Obtenha os valores das faces dos dados na mão
            var diceFaces = hand.Dices.Select(d => d.Face).ToList();

            // Agrupe os valores e conte as ocorrências
            var counts = diceFaces.GroupBy(d => d).ToDictionary(g => g.Key, g => g.Count());

            // Check for special combinations
            if (counts.Count == 6 && counts.All(kvp => kvp.Value == 1))
            {
                // 1–6 straight
                return 1500;
            }
            if (counts.Count == 3 && counts.All(kvp => kvp.Value == 2))
            {
                // Three pairs
                return 1500;
            }
            if (counts.Count == 2 && counts.Any(kvp => kvp.Value == 4) && counts.Any(kvp => kvp.Value == 2))
            {
                // Four of any number with a pair
                return 1500;
            }
            if (counts.Count == 2 && counts.All(kvp => kvp.Value == 3))
            {
                // Two triplets
                return 2500;
            }

            // Check for individual dice and sets
            foreach (var kvp in counts)
            {
                var number = kvp.Key;
                var count = kvp.Value; // Cria uma cópia local de 'count'

                if (count >= 6)
                {
                    score += 3000;
                    count -= 6;
                }
                if (count >= 5)
                {
                    score += 2000;
                    count -= 5;
                }
                if (count >= 4)
                {
                    score += 1000;
                    count -= 4;
                }
                if (count >= 3)
                {
                    score += number * 100;
                    count -= 3;
                }
                if (number == 1)
                {
                    score += count * 100;
                }
                else if (number == 5)
                {
                    score += count * 50;
                }
            }

            return score;
        }
    }
}