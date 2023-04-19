using CryptocurrencyApp.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptocurrencyApp.ViewModels
{
    class MainViewModel : ViewModel
    {
        public ViewModel CurrentViewModel { get; }
        public MainViewModel() 
        {
            CurrentViewModel = new MainPageViewModel();
        }  
    }
}
