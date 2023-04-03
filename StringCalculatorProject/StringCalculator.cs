using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorProject
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (numbers.Length == 0) return 0;

            string[] ints = numbers.Split(new char[] { ',', '\n' });

            int sum = 0;
            foreach (string s in ints)
            {
                sum += Convert.ToInt32(s);
            }
            return sum;
        }

        public int Add_SupportDifferentDelimiters(string line)
        {
            //  "//[delimiter]\n[numbers...]"
            if (line.Length == 0) return 0;

            char delimiter = line[2];
            string numbers = line.Substring(5, line.Length-5);
            string[] ints = numbers.Split(delimiter);

            int sum = 0;
            foreach (string s in ints)
            {
                sum += Convert.ToInt32(s);
            }
            return sum;
        }
    }
}
