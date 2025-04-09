using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace OOP_Polymorphism
{
    class Animal
    {
        private string name;
        protected string sound;

        protected Animal_ID_Info animal_ID_Info = new Animal_ID_Info();

        public void SetAnimal_ID_Info(int idNum, string owner)
        {
            animal_ID_Info.IDNum = idNum;
            animal_ID_Info.Owner= owner;
        }

        public void GetANimal_ID_Info()
        {
            Console.WriteLine($"{Name} had the ID of {animal_ID_Info.IDNum} and is owned by {animal_ID_Info.Owner}");
        }

        public void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound}");
        }

        public Animal():this("No Name", "No Sound") { }

        public Animal(string name):this(name, "No Sound") { }

        public Animal(string name,  string sound)
        {
            Name = name;
            Sound = sound;
 
        }

        public string Name
        {
            get { return name; } 
            set 
            {
                if (!value.Any(char.IsDigit)) {name ="No Name";  }
                 name = value;
            }
           

        }

        public string Sound
        {
            get { return sound; }
            set
            {
                if (value.Length>10) { sound = "No Sound"; }
                sound = value;
            }


        }
    }
}
