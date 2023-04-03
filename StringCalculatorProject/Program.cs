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
            
            if (WithDelimeter)
            {
                Console.WriteLine("Enter string:");
                string delimiter = Console.ReadLine();
                Console.WriteLine();
                string numbers = Console.ReadLine();
                var sc = new StringCalculator();
                Console.WriteLine(sc.Add(numbers, new char[] { delimiter[2] }));
            } 
            else
            {
                Console.WriteLine("Enter string:");
                string numbers = Console.ReadLine();
                var sc = new StringCalculator();
                Console.WriteLine(sc.Add(numbers, new char[] { ',', '\n' })); ;
            }

        }
    }
}