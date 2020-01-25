using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeSets
{
    public class ChallengeSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null)
            {
                return false;
            }
            if (ignoreCase == true)
            {
                words = words.Where(s => !String.IsNullOrEmpty(s)).ToArray();
                foreach (var n in words)
                {
                    var m = n.ToLower();
                    if (m == word)
                    {
                        return true;
                    }

                }
                return false;
            }
            else if (ignoreCase == false)
            {
                foreach (var n in words)
                {
                    if (n == word)
                    {
                        return true;
                    }
                }
                return false;
            }
            else return false;

        }

        public bool IsPrimeNumber(int num)
        {
            if (num <= 1) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(num));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            if (str.Length == 1)
            {
                return 0;
            }

            var charArr = str.All(c => c == str[0]);

            if (charArr == true)
            {
                return -1;
            }

            char letter = 'a';
            var count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str.LastIndexOf(str[i]) == str.IndexOf(str[i]))
                {
                    letter = str[i];
                    count++;
                }
            }

            if (count > 1)
            {
                for (int p = str.Length - 1;p <= 0;)
                {
                    return str.IndexOf(str[p]);

                }
            }

            for (int k = 0; k < str.Length; k++)
            {
                if (str.Length == 2)
                {
                    return 1;
                }
                if (str[k] == letter)
                {
                    return str.IndexOf(str[k]);
                }
            }
            return 0;
            
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 0;
            int temp = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                int cur_count = 1;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] != numbers[j])
                        break;
                    cur_count++;
                }

                if (cur_count > count)
                {
                    count = cur_count;
                    temp = numbers[i];
                }
            }
            return count;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            double[] empty = { };
            var newNum = new List<double>();
            int count = 0;
            if (elements == null || elements.Count == 0 || n < 0 || n > elements.Count)
            {
                return empty;
            }
            else if (elements.Count == 1)
            {
                return elements.ToArray();
            }
            else
            {
                foreach (var item in elements)
                {
                    count++;
                    if (count == n)
                    {
                        newNum.Add(item);
                        count = 0;
                    }
                }
                
                return newNum.ToArray();

            }
        }
    }
}
