using System;
using System.Linq;

namespace String_Calculator_Kata
{
    public class Calculator
    {
        public int add(String numbers)
        {
            if (numbers == "")
            {
                return 0;
            }
            char[] charArr = numbers.ToCharArray();
            char[] delimiter = { ',','\n'};
            if (charArr[0] == '/')
            {
                char[] elimiter = charArr.Skip(2).Take(1).ToArray(); 
                charArr = charArr.Skip(4).ToArray();
                delimiter = elimiter;
            }
            string[] arrnumbers = string.Join("", charArr).Split(delimiter);
            int[] ints = arrnumbers.Select(int.Parse).ToArray();
            int[] negatives= ints.Where(i => i < 0).ToArray();
            if (negatives.Length > 0)
            {
                throw new Exception("Negatives Not Allowed: " + string.Join(", ", negatives));
            }
            ints = ints.Where(i => i >= 0).ToArray();
            ints = ints.Where(i => i <= 1000).ToArray();
            return ints.Sum();
        }
    }
}