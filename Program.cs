using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string order = "45 34 24 108 76 58 64 130 80"; // string for check1
            string order1 = "    2022 70 123    3344 13";  // string for check2
            string order2 = "3 16 9 38 95 1131268 49455 347464 59544965313 496636983114762 85246814996697";
            string order3 = "11 11 2000 22 10003 123 1234000 44444444 9999";                          

            Console.WriteLine(Order(order));
            Console.WriteLine(Order(order1));
            Console.WriteLine(Order(order2));
            Console.WriteLine(Order(order3));

            Console.ReadKey();
        }

        static string Order(string input)
        {
            input = string.Join(" ", input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            if (String.IsNullOrEmpty(input))
                return ("is null or empty, please try again");
            else
            {
                ulong[] list1 = input.Split(' ').Select(UInt64.Parse).ToArray();

                double[] keys = new double[list1.Length];

                for (int i = 0; i < keys.Length; i++)
                {
                    keys[i] = FindSumm(list1[i]);
                }
                
                Array.Sort(keys, list1);
                string result = "";
                for (int i = 0; i < list1.Length; i++)
                {
                    result += (list1[i]);
                    if((i+1) != list1.Length )
                        result += " ";
                }

                return result;
            }
        }

        static double FindSumm(ulong a)
        {
            string partic = Convert.ToString(a);
            char[] b = partic.ToArray();
            double summ = 0;
            for (int i = 0; i < b.Length; i++)
            {
                summ += (int.Parse(b[i].ToString()));
            }
            summ += (a/(Math.Pow(10, b.Length)));
            return summ;
        }
    }

}
