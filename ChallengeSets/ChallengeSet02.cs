using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeSets
{
    public class ChallengeSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return (c >= 'A' && c<='Z') || (c>='a' && c<='z');
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            int length = vals.GetLength(0);
            if (length % 2 == 0)
            {
                return true;
            }
            else return false;
            
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else return false;
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 == 0)
            {
                return false;
            }
            else return true;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            else if (!numbers.Any())
            {
                return 0;
            }
            else 
            {

                double min = numbers.Min();
                double max = numbers.Max();

                double sum = min + max;
                return sum;
            }
            
            

           
            
        }
        public int GetLengthOfShortestString(string str1, string str2)
        {
            int length1 = str1.Length;
            int length2 = str2.Length;

            if (length1 < length2)
            {
                return length1;
            }
            else
            {
                return length2;
            }
        }

        public int Sum(int[] numbers)
        {
            int sum = 0;
            if (numbers == null)
            {
                return 0;
            }
            else
            {
                for (int i = 0; i < numbers.Length; i++)
                {

                    sum += numbers[i];
                }
                    return sum;
            }       
        }

        public int SumEvens(int[] numbers)
        {
            int sum = 0;
            if (numbers == null)
            {
                return sum;
            }
            else
            {
                foreach (int num in numbers)
                {
                    if (num % 2 == 0)
                    {
                        sum += num;
                    }
                    
                }
                return sum;
                
            }

            
        }

        public bool IsSumOdd(List<int> numbers)
        {
            int sum = 0;
            if (numbers == null)
            {
                return false;
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            if (sum % 2 != 0)
            {
                return true;
            }
            else return false;
            

            
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            throw new NotImplementedException();
        }
    }
}
