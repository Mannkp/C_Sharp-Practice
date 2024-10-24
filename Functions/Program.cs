using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Functions
{
    class Program
    {
        public static void Main(string[] args) {
            try
            {
                Console.WriteLine("Addition Program: ");

                string[,] names = { { "a" }, { "b" } };

                int firstNum = ReadInt("Enter first number");
                int secondNum = ReadInt("Enter second number");
                int thirdNum = ReadInt("Enter third number");

                Console.WriteLine($"Addition of {firstNum} and {secondNum} is: {Addition(a: firstNum, b: secondNum)}"); //passing parameters this way helps us to pass parameters in any order

                Console.WriteLine($"Addition of {firstNum}, {secondNum} and {thirdNum} is: {Addition(firstNum, secondNum, thirdNum)}");

                var nn = new Hello("Abc");
                Console.WriteLine($"Hiiii, this is {nn.Name}");

                nn.PrintName();

                var sss = new Mustang();
                sss.EngineSound();
                sss.Hello();

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


        class Hello
        {
            private string name = "Mann";



            public string Name {
                get {
                    return name;
                }
                set
                {
                    name = value;
                }
            }

            public string d { get; } = "Mannnn"; //read only

            public void PrintName()
            {
                Console.WriteLine($"Hello: {name}");
            }
            public Hello(string inp) {
                Name = inp;
            }
        }


        interface IDevice
        {
            void Identify();
        }

        interface IVehicle
        {
            void EngineSound();
        }

        class Smartphone : IDevice
        {
            public void Identify()
            {
                Console.WriteLine("This is a Smartphone");
            }
        }

        class Mustang : IVehicle
        {
            public void EngineSound()
            {
                Console.WriteLine("V8 Sound!!!! Wrooooooom Wrooooooom");
            }

            public void Hello()
            {
                Console.WriteLine("hhh");
            }
        }
    }
}