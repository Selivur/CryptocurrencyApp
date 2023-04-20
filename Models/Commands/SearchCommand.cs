using CryptocurrencyApp.Stores;
using CryptocurrencyApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CryptocurrencyApp.Models.Commands
{
    internal class SearchCommand : CommandBase
    {
        private readonly NavigationStore _navigationStore;
        public SearchCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }
        public override void Execute(object parametr)
        {
            if(CurrencyList.Contains(MainPageViewModel.GetSearchField()))
                _navigationStore.CurrentViewModel = new CryptocurrencyInfoViewModel();
            else
                MessageBox.Show("Invalid name of cryptocurrency", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
