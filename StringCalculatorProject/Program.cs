using System;
using StringCalculatorProject;


namespace KataProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter string contains any amout of numbers: ");
            string numbers = "2,3\n4";

            var sc = new StringCalculator();
            Console.WriteLine(sc.Add(numbers));
        }
    }
}