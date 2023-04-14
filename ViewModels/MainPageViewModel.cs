using CryptocurrencyApp.Models;
using CryptocurrencyApp.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CryptocurrencyApp.ViewModels
{
    internal class MainPageViewModel : ViewModel
    {
        private List<string> _currencyList = CurrencyTopList.GetList();
        
        public ICommand SearchCommand { get;}
    }
}
