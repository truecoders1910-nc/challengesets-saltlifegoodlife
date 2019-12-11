using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeSets
{
    public class ChallengeSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            int num1 = 0;
            foreach (var value in vals)
            {
                if (value == false)
                {
                    num1++;
                }

            }
            if (num1 > 0)
            {
                return true;
            }
            else return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }

            int sum = 0;
            foreach (int num in numbers)
            {
                if (num % 2 != 0)
                {
                    sum = sum + num;
                }
            }
            if (sum % 2 != 0)
            {
                return true;
            }
            else return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (password.Any(char.IsDigit) && password.Any(char.IsUpper) && password.Any(char.IsLower))
            {
                return true;
            }
            else return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {

            string one = val.Substring(val.Length - 1);
            return Convert.ToChar(one);
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }

            else return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }
        public int[] GetOddsBelow100()
        {
            List<int> odds = new List<int>();
            for (int i = 1; i < 100; i += 2)
            {
                odds.Add(i);
            }
            return odds.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
            
        }
    }
}
