using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dedicnost
{
    internal class Program
    {
        class Animal
        {
            public string name;
            public int maxAge;

            public virtual void MakeNoise()
            {
                Console.WriteLine("*animal noise*");  
            }
        }
        class Dog:Animal
        {
            public string race;
            public override void MakeNoise()
            {
                Console.WriteLine("Haf");   
            }
            
        }

        class CAt : Animal
        {
            public string furcolor;
            public override void MakeNoise()
            {
                Console.WriteLine("Mnau mnau motherfucker");
            }
        }

        static void Main(string[] args)
        {
            Animal newanimal = new Animal();
            newanimal.MakeNoise();
            
            Dog newDog = new Dog();
            newDog.name = "Fík";
            newDog.maxAge = 14;
            newDog.race = "Laika";
            Console.WriteLine($"{newDog.name} is {newDog.maxAge} years old and is a {newDog.race}");
            newDog.MakeNoise();

            CAt newCat = new CAt();
            newCat.name = "Micka";
            newCat.maxAge = 15;
            newCat.furcolor = "orange";
            Console.WriteLine($"{newCat.name} is {newCat.maxAge} years old and is {newCat.furcolor}");
            newCat.MakeNoise();
            Console.ReadKey();
        }
    }
}
