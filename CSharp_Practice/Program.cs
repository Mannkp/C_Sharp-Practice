// See https://aka.ms/new-console-template for more information

using System;
using MySecondProject;

namespace CSharp_Practice
{
    public class MyApp
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");

            //strings
            string name = "MANN"; //strings are immutable

            string sentence = $"His name is {name}"; //string Interpolation

            Console.WriteLine(sentence.ToUpper().Trim());

            Console.WriteLine(sentence.Contains(name));

            int a = 0;

            double b = 1.23;

            float c = 1.123f;

            decimal d = 1.2345m;

            //Conditional and Loops

            if (a + b > 0)
            {
                Console.WriteLine($"{a}, {b}, {c}");
            }

            //Consider List<T> as Cup<T>

            var names = new List<string> { "Mann", "Jiya" };
            names.Add("Bindu");
            names.Add("Ketan");

            Console.WriteLine("\n\n\n\n\n***********************************");

            foreach (var personName in names)
            {
                Console.WriteLine($"Name {names?.IndexOf(personName)}: {personName}");
            }

            //print first name:
            Console.WriteLine($"Name: {names[0]}");

            //print last name:
            Console.WriteLine($"Name: {names[^1]}");

            //print second-last name:
            Console.WriteLine($"Name: {names[^2]}");


            //Arrays in c#

            var newNames = new string[] { "Mann", "Jiya", "Bindu", "Ketan" };

            Console.WriteLine("\n\nNew Names: ");
            foreach (var personName in newNames)
            {
                Console.WriteLine($"{Array.IndexOf(newNames, personName)}. {personName}");
            }

            //Note: Arrays are Fixed in Length.

            //So to update array, we can create a new array with updated values and append it/assign it to our array!

            newNames = [.. newNames, "Pandya"];

            Console.WriteLine("\n\nUpdated New Names: ");
            foreach (var personName in newNames)
            {
                Console.WriteLine($"{Array.IndexOf(newNames, personName)}. {personName}");
            }




            //LINQ = Language Integrated Query:

            List<int> scores = [90, 76, 87, 92, 86, 85];

            IEnumerable<int> filteredScores = from score in scores
                                              where score > 80
                                              orderby score ascending
                                              select score;

            List<int> finalScores = filteredScores.ToList();

            Console.WriteLine($"Scores Greater than 80:");

            foreach (int i in finalScores)
            {
                Console.WriteLine($"{i}");
            }


            //Queries in c#

            var scoreQuery = scores.Where(s => s > 80).OrderByDescending(s => s);




            //OOPs in c#

            var personMann = new NewPeople("Mann", new DateOnly(2003, 05, 10));

            personMann.Pets.Add(new Dog("Tommy"));
            personMann.Pets.Add(new Cat("Mimi"));

            var personJiya = new NewPeople("Jiya", new DateOnly(2008, 11, 05));

            var personKetan = new NewPeople("Ketan", new DateOnly(1973, 05, 07));

            var personBindu = new NewPeople("Bindu", new DateOnly(1974, 06, 18));
            
            

            List<NewPeople> family = [personMann, personJiya, personBindu, personKetan];



            Console.WriteLine("\n\n\n\n***********************************************");
            
            Console.WriteLine("My Family Details");

            foreach(var person in family)
            {
                person.PrintPersonDetails();

                if (person?.Pets?.Count > 0) {

                    foreach (var pet in person?.Pets)
                    {
                        Console.WriteLine($"Has Pet Named: {pet?.Name}");
                        Console.WriteLine(pet);
                        pet?.MakesNoise();
                    }
                }
            }

            //importing class and methods from another project

            var printingName = new MannPandya();
            printingName.PrintName();
          
        }
    }
}