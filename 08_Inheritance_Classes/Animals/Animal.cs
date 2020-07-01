using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Inheritance_Classes.Animals
{

    public enum DietType { Herbivore = 1, Omnivore, Carnivore, Insectivore}
    public abstract class Animal
    {
        public int NumberOfLegs { get; set; }

        public bool IsMammal { get; set; }

        public bool HasFur { get; set; }

        public bool Endangered { get; set; }

        public DietType TypeOfDiet { get; set; }


        // virtual can be redefined in a derived class
        public virtual void Move()
        {
            Console.WriteLine($"This {GetType().Name} moves.");
        }
    }
}
