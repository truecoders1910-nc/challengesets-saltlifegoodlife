using System;
using System.Collections.Generic;
using System.Linq;
namespace ChallengeSets
{
    public class ChallengeSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int final = 0;
            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                {
                    final = num + final;
                }
                else 
                {
                    final = final - num;
                }
            }
            return final;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {

            List<string> str = new List<string>();
            str.Add(str1);
            str.Add(str2);
            str.Add(str3);
            str.Add(str4);
            
            int min = str1.Count();
            foreach  (string word in str)
            {
               int num = word.Count();
                if (num < min)
                {
                    min = num;
                }
                
            }
            return min;
            
            
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            List<int> numbers = new List<int>();

            numbers.Add(number1);
            numbers.Add(number2);
            numbers.Add(number3);
            numbers.Add(number4);
            int min = number1;
            foreach (int num in numbers)
            {
                if (num < min)
                {
                    min = num;
                }
                
            }
            return min;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            Business business = new Business();
            biz.Name = "TrueCoders";
            return;
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 + sideLength2 <= sideLength3 || sideLength1 + sideLength3 <= sideLength2 || sideLength2 + sideLength3 <= sideLength1)
            {
                return false;

            }
            else return true;
        }

        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out double n);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int nullCounter = 0;
            int counter = 0;

            foreach (var item in objs)
            {
                counter++;
                if (item == null)
                {
                    nullCounter++;
                }
            }
            if (nullCounter > counter / 2)
            {
                return true;
            }
            else return false;
        }

        public double AverageEvens(int[] numbers)
        {
            double result = 0;
            double counter = 0;
            if (numbers == null)
            {
                return 0;
            }
            else if (numbers.Length == 0)
            {
                return 0;
            }
            else
            {
                foreach (int num in numbers)
                {

                    if (num % 2 == 0)
                    {
                        result += num;
                        counter++;
                    }
                    else result += 0;
                    
                }
                if (result == 0)
                {
                    return 0;
                }
                else return result / counter;
                

            }
        }

        public int Factorial(int number)
        {
            if (number >= 0)
            {
                int i, fact = 1;
                for (i = 1; i <= number; i++)
                {
                    fact = fact * i;
                }
                return fact;
            }
            else
            {
               throw new ArgumentOutOfRangeException();
            }
        }
    }
}
