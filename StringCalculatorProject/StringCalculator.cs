using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorProject
{
    public class StringCalculator
    {
        public int Add(string numbers, char[] delimiter)
        {
            if (numbers.Length == 0) return 0;

            string[] ints = numbers.Split(delimiter);

            bool existNegativeNumbers = false;
            List<int> negativeNums = new List<int>();
            int sum = 0;
            foreach (string s in ints)
            {
                int num = Convert.ToInt32(s);
                existNegativeNumbers = num < 0 ? true : false;
                if(existNegativeNumbers)
                {
                    negativeNums.Add(num);
                }
                sum += num <= 1000 ?num:0;
            }
            if(negativeNums.Count>0)
            {
                string exception = "negatives not allowed: ";
                foreach(int i in negativeNums)
                {
                    exception = exception + i.ToString();
                }
                throw new Exception( exception);
            }
            return sum;
        }

        /*public int Add_SupportDifferentDelimiters(string line)
        {
            //  "//[delimiter]\n[numbers...]"
            if (line.Length == 0) return 0;

            char delimiter = line[2];
            string numbers = line.Substring(4, line.Length-4);
            string[] ints = numbers.Split(delimiter);

            int sum = 0;
            foreach (string s in ints)
            {
                sum += Convert.ToInt32(s);
            }
            return sum;
        }*/
    }
}
