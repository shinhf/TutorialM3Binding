using Tutorial_M3_Binding_Hamburger.ViewModels;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Tutorial_M3_Binding_Hamburger.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class M3Practice3Binding : Page
    {
        public M3Practice3Binding()
        {
            this.InitializeComponent();
            Animals = new AnimalsViewModel();
        }

        public AnimalsViewModel Animals { get; set; }
    }
}
