using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_M3_Binding_Hamburger.Models
{
    public class Animals
    {
        public List<Animal> AnimalsList;

        public Animals()
        {
            AnimalsList = new List<Animal>();
            //pregenerated data, can be done in Data layer
            Add(new Animal { ID = 1, CommonName = "Dog" });
            Add(new Animal { ID = 2, CommonName = "Cat" });
            Add(new Animal { ID = 3, CommonName = "Horse" });
        }

        public void Add(Animal animal)
        {
            AnimalsList.Add(animal);
        }
    }
}
