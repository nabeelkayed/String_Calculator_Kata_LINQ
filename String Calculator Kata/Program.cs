using System;

namespace String_Calculator_Kata
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator newcalculator = new Calculator();
            Console.WriteLine("Please Enter the numbers separated by comma:");
            Console.WriteLine($"The sum = {newcalculator.add(Console.ReadLine())}"); 
        }
    }
}
