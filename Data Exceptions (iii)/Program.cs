/* #############################
 * 
 * Author: Johnathon Mc Grory
 * Date :
 * Description : Exception Handling
 * 
 * ############################# */
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Exceptions__iii_
{
    class Program
    {
        static int[] Scores = new int[10];
        static void Main(string[] args)
        {

            for (int i = 0; i < Scores.Length; i++)
            {
                try
                {
                    Console.WriteLine("Enter your test score: ");
                    Scores[i] = int.Parse(Console.ReadLine());
                    if (Scores[i] < 0 || Scores[i] > 100)
                    {
                        Console.WriteLine("invalid");
                        i--;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Incorrect formatting try again");
                    i--;
                }
            }
            int average = Average();
            Console.WriteLine("The average is {0}", average);
        }

        static int Average()
        {
            int average = 0;
            try
            {
                int total = 0;
                for (int i = 0; i < Scores.Length; i++)
                {
                    total = total + Scores[i];
                    average = total / Scores.Length - 1;
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("This index is out of range, try again");
            }
            return average;
        }
    }
}
