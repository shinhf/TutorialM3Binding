using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Tutorial_M3_Binding_Hamburger.ViewModels.Commands
{
    public class ViewCommands : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public AnimalsViewModel ViewModel { get; set; }

        public ViewCommands(AnimalsViewModel ViewModel)
        {
            this.ViewModel = ViewModel;
        }

        public bool CanExecute(object send)
        {
            return false;
        }

        public void Execute(object send)
        {
            this.ViewModel.AddData1();
        }




    }
}
