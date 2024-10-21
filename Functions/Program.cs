using System;
using System.Runtime.InteropServices;

namespace Functions
{
    class Program
    {
        public static void Main(string[] args) {
            try
            {
                Console.WriteLine("Addition Program: ");

                int firstNum = ReadInt("Enter first number");
                int secondNum = ReadInt("Enter second number");
                int thirdNum = ReadInt("Enter third number");

                Console.WriteLine($"Addition of {firstNum} and {secondNum} is: {Addition(a: firstNum, b: secondNum)}"); //passing parameters this way helps us to pass parameters in any order

                Console.WriteLine($"Addition of {firstNum}, {secondNum} and {thirdNum} is: {Addition(firstNum, secondNum, thirdNum)}");



                //Exception Handling 
            }
            catch (Exception e) {
                Console.WriteLine($"Error: {e?.Message}");
            }
             
        }
        
        static int ReadInt(string message = "Enter a value")
        {
            Console.WriteLine($"{message}: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static int Addition(int a, int b=0) { 
            return a + b;
        }
        static int Addition(int a, [Optional] int b, int c) { 
            return a + b + c;
        }
    }
}