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

namespace Data_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int hours;
            string input;
            bool isValid = false;
            do
            {
                Console.WriteLine("Please enter your name: ");
                string name = Console.ReadLine();
                if (String.IsNullOrEmpty(name))
                    isValid = false;
                else isValid = true;

            } while (isValid == false);
            do
            {
                Console.WriteLine("Please enter your ID number: ");
                string id = Console.ReadLine().ToUpper();
                if (String.IsNullOrEmpty(id))
                    isValid = false;
                else isValid = true;

                if (id[0] != 'E')
                    isValid = false;
                else isValid = true;


                if (id.Length > 6 || id.Length < 6)
                    isValid = false;
                else isValid = true;

            } while (isValid == false);
            do
            {
                Console.WriteLine("Please enter the number of hours worked: ");
                input = Console.ReadLine();
                hours = int.Parse(input);
                if (IsPresent(input, "hours") == true && IsInteger(input, "hours") == true && IsWithInRange(input, "hours", 10, 50) == true)
                isValid = true;
                else isValid = false;
                //you have to create these methods yourself boi//

            } while (isValid == false);

            Console.WriteLine("Please enter your hourly rate: ");
            string RATE = Console.ReadLine();
            if (IsPresent(RATE, "rate") == true && IsInteger(RATE, "age") == true && IsWithInRange(RATE, "age", 10, 65) == true)
                isValid = true;
            else isValid = false;
            double rate = double.Parse(RATE);
            double beforeTax = rate * hours;
            double tax = 0;
            if (beforeTax < 3000)
            {
                tax = 0;
            }
            else if (beforeTax > 3000 && beforeTax < 34000)
            {
                tax = beforeTax * .20;
            }
            else
            {
                tax = beforeTax * .40;
            }
            double takeHome = beforeTax - tax;
            Console.WriteLine("Your tax is {0:c}", tax);
            Console.WriteLine("Your take home is {0:c}", takeHome);

        }


        //methods



        static bool IsPresent(string input, string itemName)
        {
            if (input != "")
                return true;
            else
            {
                Console.WriteLine("You must enter a value for {0}", input);
                return false;
            }
        }
        static bool IsInteger(string textIn, string itemName)
        {

            bool isOK;
            int num;

            isOK = int.TryParse(textIn, out num);

            if (isOK == true)
                return true;
            else
            {
                Console.WriteLine("{0} must be of type integer", itemName);
                return false;
            }
        }
        static bool IsDouble(string textIn, string itemName)
        {

            bool isOK;
            double num;

            isOK = double.TryParse(textIn, out num);

            if (isOK == true)
                return true;
            else
            {
                Console.WriteLine("{0} must be of type integer", itemName);
                return false;
            }
        }
        static bool IsWithInRange(string textIn, string itemName, int min, int max)
        {
            int num = int.Parse(textIn);

            if (num >= min && num <= max)
                return true;
            else
            {
                Console.WriteLine("{0} must be within the range", itemName);
                return false;
            }
        }
    }
}
