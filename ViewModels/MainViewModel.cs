using CryptocurrencyApp.Stores;
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
        private readonly NavigationStore _navigationStore;
        public ViewModel CurrentViewModel => _navigationStore.CurrentViewModel;
        public MainViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
            _navigationStore.CurrentViewModelChanged+= OnCurrentViewModelChanged;  
        }
        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}
