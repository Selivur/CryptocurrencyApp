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
    internal class NavigateOnMainCommand : CommandBase
    {
        private readonly NavigationStore _navigationStore;
        public NavigateOnMainCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }
        public override void Execute(object parametr)
        {
            _navigationStore.CurrentViewModel = new MainPageViewModel(_navigationStore);
        }
    }
}
