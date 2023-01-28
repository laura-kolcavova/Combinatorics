using System;
using System.Collections.Generic;
using System.Text;

namespace Combinatorics
{
    public static class Combinatorics
    {
        public static IEnumerable<int[]> Combinations(int[] numbers, int combinationLength)
        {
            int combinationCount = (int)Math.Pow(numbers.Length, combinationLength);

            for (int i = 0; i < combinationCount; i++)
            {
                int[] combination = CreateCombination(numbers, combinationLength, i);
                yield return combination;
            }
        }

        private static int[] CreateCombination(int[] numbers, int combinationLength, int combinationIndex)
        {
            int[] combination = new int[combinationLength];

            for (int i = 0; i < combinationLength; i++)
            {
                int reverseIndex = combinationLength - 1 - i;

                int pow = (int)Math.Pow(numbers.Length, reverseIndex);

                int d = combinationIndex / pow;

                int index = d % numbers.Length;

                combination[i] = numbers[index];
            }

            return combination;
        }
    }
}
