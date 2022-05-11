using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview.Code.Chapter_1
{
    public static class Question1_2
    {
        //1.2 Check Permutation: Given two strings, write a method to decide if one is a permutation of the other
        //1.2 Для двух строк напишите метод, определяющий, является ли одна строка перестановкой другой.

        private static bool IsValidArgs(string string1, string string2)
        {
            if (string.IsNullOrEmpty(string1) || string.IsNullOrEmpty(string2))
            {
                throw new ArgumentException("Input strings cannot be null or empty");
            }

            if (string1.Length != string2.Length)
            {
                return false;
            }

            return true;
        }

        // Space: O(N)
        // Time: O(N log N)
        public static bool AreStringsPermutation(string string1, string string2)
        {
            if (!IsValidArgs(string1, string2)) return false;

            var sortedStr1 = string.Concat(string1.OrderBy(c => c));
            var sortedStr2 = string.Concat(string2.OrderBy(c => c));

            return sortedStr1.Equals(sortedStr2);
        }

        // Space: O(N)
        // Time: O(N)
        public static bool AreStringsPermutationNoSort(string string1, string string2)
        {
            if (!IsValidArgs(string1, string2)) return false;

            Dictionary<char, int> allChars = new Dictionary<char, int>();

            for (int i = 0; i < string1.Length; i++)
            {
                var c = string1[i];

                if (allChars.ContainsKey(c))
                {
                    allChars[c]++;
                }
                else
                {
                    allChars[c] = 1;
                }
            }

            for (int i = 0; i < string2.Length; i++)
            {
                var c = string2[i];
                if (!allChars.ContainsKey(c))
                {
                    return false;
                }
                else
                {
                    allChars[c]--;
                }
            }

            return true;
        }
    }
}
