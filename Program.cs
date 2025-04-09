using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal whiskers = new Animal()
            {
                Name = "Wiskers",
                Sound = "Meow"
            };


            Dog grover = new Dog()
            {
                Name = "Grover",
                Sound = "Woof",
                Sound2 = "Grrr"
            };

            grover.Sound = "Wooooof";

            whiskers.MakeSound();
            grover.MakeSound();

            whiskers.SetAnimal_ID_Info(384, "Gomer");
            grover.SetAnimal_ID_Info(21343, "Paulina");


            whiskers.GetANimal_ID_Info();
            grover.GetANimal_ID_Info();

            Animal.AnimalHealth getHealth = new Animal.AnimalHealth();

            Console.WriteLine("Is my animal healty : {0}", getHealth.HealtyWeight(11,146));

            Animal monkey = new Animal()
            {
                Name = "Happy",
                Sound = "Eeeeee"
            };

            Animal spot = new Dog()
            {
                Name = "Spot",
                Sound = "Woaooowff",
                Sound2 = "Grrrrrrrraw"
            };
        }
    }
}
