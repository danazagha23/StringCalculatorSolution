using System;
using StringCalculatorProject;


namespace KataProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter string with delimiters: [yes, no]");
            bool WithDelimeter = Console.ReadLine() == "yes"? true: false;

            Console.WriteLine("Enter string:");
            string numbers = Console.ReadLine();
            var sc = new StringCalculator();
            if (WithDelimeter)
            {
                Console.WriteLine(sc.Add_SupportDifferentDelimiters(numbers));
            } 
            else
            {
                Console.WriteLine(sc.Add(numbers));
            }

        }
    }
}