using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu.ViewModel
{
    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        int page = 1;



    }
}
