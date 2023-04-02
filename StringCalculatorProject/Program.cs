using System;
using StringCalculatorProject;


namespace KataProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter string contains from 0 to 3 numbers: ");
            string numbers = Console.ReadLine();

            var sc = new StringCalculator();
            Console.WriteLine(sc.Add(numbers));
        }
    }
}