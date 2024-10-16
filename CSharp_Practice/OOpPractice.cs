using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharp_Practice
{

    //abstract (concept) class
    public abstract class Pet(string name)
    {
        public string Name { get; } = name;

        public abstract string MakesNoise();

        public override string ToString()
        {
            //Console.WriteLine($"{Name} is a {GetType().Name} and I {MakesNoise()}");
            return $"{Name} is a {GetType().Name}";
        }
    }




    //method 1: old way of doing these..

    public class People
    {
        public People(string name, DateOnly DoB) {
            Name = name;
            DateOfBirth = DoB;
        }

        //setting Access Modifiers to private so that below states can be modified only via this class

        private string Name;

        private DateOnly DateOfBirth;

        public void PrintPersonDetails()
        {
            Console.WriteLine($"Name is {Name} and Date of Birth is {DateOfBirth}");
        }

        public override string ToString()
        {
            return "jhiiihdfngsfngjnrbnvslnkbvnkdz";
        }

    }



    //new method

    public class NewPeople(string name, DateOnly DoB)
    {
        private string Name { get; } = name;

        private DateOnly DateOfBirth { get; } = DoB;

        public void PrintPersonDetails()
        {
            Console.WriteLine($"Name is {Name} and Date of Birth is {DateOfBirth}");
        }


        //people got pets
        public List<Pet> Pets { get; } = new(); //so new() makes sure people have pets or no pets, but pets do exist not like there is nothing like pets!

    }



    // here, Dog and Cat class are based on abstract class Pet and the value name coming from Dog/Pet class initialization goes to Pet Class and we can access it through Dog/Cat class as both are based on Pet class and state value was stored on Pets..

    public class Dog(string name) : Pet(name)
    {
        public override string MakesNoise()
        {
            Console.WriteLine("Barks woof woof");
            return "Barks woof woof";   
        }
    }
    
    public class Cat(string name) : Pet(name)
    {
        public override string MakesNoise()
        {
            Console.WriteLine("Meows meow meow");
            return "Meows meow meow";   
        }
    }


    


}


// Abstract is like concept, we create classes based on this concept(abstract) and it shapes our classes we implement.
// we need to override the methods(function) to define body for them.