using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorial_M3_Binding_Hamburger.Models;

namespace Tutorial_M3_Binding_Hamburger.ViewModels
{
    public class AnimalViewModel : Animal
    {
        public AnimalViewModel()
        {
        }

        public AnimalViewModel(Animal animal) 
        {
            this.ID = animal.ID;
            this.CommonName = animal.CommonName;
        }
    }
}
