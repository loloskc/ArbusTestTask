using Menu.ViewModel;

namespace Menu
{
    public partial class MainPage : ContentPage
    {

        public MainPage(PageViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }

}
