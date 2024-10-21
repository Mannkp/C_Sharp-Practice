using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySecondProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Mann";

            int a = 703;
            int b = 4;

            int c = calculateRemainder(a, b);

            Console.WriteLine($"Remainder of {a} divided by {b} is {c}");

            a = 0;

            Console.WriteLine($"Remainder of {a} divided by {b} is {calculateRemainder(a, b)}");



            Console.WriteLine("Enter Name: ");
            try
            {

                name = Console.ReadLine();

            }
            catch (Exception e) { Console.WriteLine($"Error: {e}"); }
            Console.WriteLine($"Entered Name: {name}");





            Console.WriteLine("Enter Day from 1 to 7");
            int day = Convert.ToInt32(Console.ReadLine());

            //switch case

            switch (day)
            {

                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Satday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("incorrect input");
                    break;
            }


            Console.WriteLine("Conditional Operator Example , Enter Age: ");

            int age = 0;

            string inputAge = Console.ReadLine();

            int.TryParse(inputAge, out age); //this method trys to convert string into int and if successful, stores value in variable written with out.

            //int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(age > 0 ? $"Valid age: {age}" : $"Invalid age: {age}");


            //formatting decimal numbers

            double money = 10D / 3D;

            Console.WriteLine(string.Format("$10 / $3 = ${0:0.00}", money));  //{0} indicates first variable to be printed here and {0:0.00} means format decimal this way.. after decimal point display upto two values.

            //Console.WriteLine(money.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));


            int n = 0;
            Console.WriteLine("\n\n\nEnter integer Value to Print Table of: ");
            string tableInput = Console.ReadLine();
            int.TryParse(tableInput, out n);

            var tableDemo = new Tables();
            tableDemo.TableOf(n);



            // .Equals can be used to compare two strings 

            string s1 = "Mann";
            string s2 = "Mann";

            Console.WriteLine(s1.Equals(s2) ? "Strings are Equal" : "Strings are different");

            if (!string.IsNullOrEmpty(s1)) Console.WriteLine(s1);


            //Password checker
            Console.WriteLine("\n\nPassword checker");
            Console.WriteLine("Enter Password: ");
            string pass1 = Console.ReadLine();
            Console.WriteLine("Confirm Password: ");
            string pass2 = Console.ReadLine();

            if (!string.IsNullOrEmpty(pass1) && !string.IsNullOrEmpty(pass2))
            {
                if (pass1.Equals(pass2))
                {
                    Console.WriteLine("Password Match!");
                }
                else
                {
                    Console.WriteLine("Password Didn't match");
                }
            }
            else
            {
                Console.WriteLine("Please Enter a Password");
            }




            //Lists in c#

            Console.WriteLine("Lists in c#");


            List<int> listNumbers = new List<int>() { 1, 2, 3, 4, 5, 6 };

            foreach (var number in listNumbers)
            {
                Console.WriteLine($"{number}");
            }







            //Dictionary in c#

            Console.WriteLine("Dictionary in c#");

            Dictionary<int, string> names = new Dictionary<int, string>()
            {
                {0, "Test" }
            };

            names.Add(1, "Mannkumar Pandya");

            names.Add(2, "Jiya Pandya");


            foreach (var item in names)
            {
                Console.WriteLine($"key: {item.Key} - value: {item.Value}");
            }

            //approach 2
            for (int i=0; i<names.Count; i++)
            {
                KeyValuePair<int, string> pair = names.ElementAt(i);
                Console.WriteLine($"{pair.Key} - {pair.Value} ");
            }




            //example:

            List<int> evenNumbers = new List<int>();

            List<int> oddNumbers = new List<int>();

            for (int i=0; i<=20; i++)
            {
                if (i % 2 == 0) 
                {
                    evenNumbers.Add(i);
                }
                else
                {
                    oddNumbers.Add(i);
                }
            }

            Console.WriteLine("\nEven Numbers: ");
            foreach (var number in evenNumbers)
            {
                Console.Write($"{number} ");
            }
            
            Console.WriteLine("\nOdd Numbers: ");
            foreach (var number in oddNumbers)
            {
                Console.Write($"{number} ");
            }


            int num = 0;
            int len = 0;

            Console.WriteLine("\n\nEnter Number to find multiples: ");
            string numInput = Console.ReadLine();
            Console.WriteLine("Enter length: ");
            string lenInput = Console.ReadLine();

            int.TryParse( numInput, out num);
            int.TryParse( lenInput, out len);

            int[] mulArr = new int[len];

            for (int i = 0; i < len; i++)
            {
                mulArr[i] = num*(i+1);
            }

            Console.WriteLine($"{len} Multiples of {num}:");
            foreach (int i in mulArr)
            {
                Console.Write($"{i} ");
            }


            Console.ReadLine();
        }

        public static int calculateRemainder(int a, int b)
        {
            return a % b;
        }
    }



    public class MannPandya
    {
        public void PrintName()
        {
            Console.WriteLine("Mannkumar Ketankumar Pandya is a Hero");
        }
    }

    public class Tables
    {
        public void TableOf(int number)
        {
            //var tableValue = new List<string> { };
            for (int i = 0; i < 10; i++)
            {
                //tableValue.Add($"{number} X {i+1} = {number*(i+1)}");
                Console.WriteLine($"{number} X {i + 1} = {(number * (i + 1)):00}");
            }
        }
    }
}
