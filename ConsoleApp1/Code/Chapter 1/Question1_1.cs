using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview.Code.Chapter_1
{
    public static class Question1_1
    {
        // 1.1 Реализуйте алгоритм, определяющий, все ли символы в строке встречаются только один раз.
        // А если при этом запрещено использование дополнительных структур данных?

        // Space: O(N)
        // Time: O(N)
        public static bool AreAllCharactersUnique(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return true;
            }

            HashSet<char> hashSet = new HashSet<char>();

            foreach (var symbol in input)
            {
                if (!hashSet.Add(symbol))
                {
                    return false;
                }
            }

            return true;
        }

        // Space: O(1)
        // Time: O(N^2)
        public static bool AreAllCharactersUniqueNoAdditionalMemory(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return true;
            }

            for (int i = 0; i < input.Length - 1; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] == input[j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
