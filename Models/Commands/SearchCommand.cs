using CryptocurrencyApp.Stores;
using CryptocurrencyApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            _navigationStore.CurrentViewModel = new CryptocurrencyInfoViewModel();
        }
    }
}
