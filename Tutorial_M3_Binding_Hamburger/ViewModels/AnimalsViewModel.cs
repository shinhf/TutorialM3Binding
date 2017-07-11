using System.Collections.ObjectModel;
using Tutorial_M3_Binding_Hamburger.Models;
using Tutorial_M3_Binding_Hamburger.ViewModels.Commands;

namespace Tutorial_M3_Binding_Hamburger.ViewModels
{
    public class AnimalsViewModel
    {
        public ObservableCollection<AnimalViewModel> CollectionOfAllAnimals { get; set; }
        public ViewCommands ViewCommand { get; set; }
        public AnimalsViewModel()
        {
            CollectionOfAllAnimals = 
                new ObservableCollection<AnimalViewModel>();
            this.ViewCommand = new ViewCommands(this);
            var animals = new Animals();

            foreach (var temp in animals.AnimalsList)
            {
                CollectionOfAllAnimals.Add(new AnimalViewModel(temp));
            }
        }

        public void AddData1()
        {
        //    AnimalsList.Add(new Animal() { ID = 4, CommonName = "Pigeon" });
        //       CollectionOfAllAnimals.Add(
          //      new AnimalViewModel() { ID = 4, CommonName = "Pigeon" }
            //    );
        }

        public void AddData(int id, string commonName)
        {
            CollectionOfAllAnimals.Add(
                new AnimalViewModel() { ID = id, CommonName = commonName }
                );
        }
    }
}
