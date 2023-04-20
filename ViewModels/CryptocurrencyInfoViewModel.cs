using CryptocurrencyApp.Models;
using CryptocurrencyApp.Models.Commands;
using CryptocurrencyApp.Stores;
using CryptocurrencyApp.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CryptocurrencyApp.ViewModels
{
    internal class CryptocurrencyInfoViewModel : ViewModel
    {
        private readonly CurrencyInfo _currencyData;
        public string Name => _currencyData.Name;

        public string Price => "Price:\t"+_currencyData.Price.ToString();

        public string VolumeUsd24Hr => "Volume:\t"+_currencyData.VolumeUsd24Hr.ToString();
       
        public string ChangePercent24Hr => "Change:\t"+_currencyData.ChangePercent24Hr.ToString();
        public List<CurrencyMarket> _marketsList=CurrencyMarket.CurrencyMarkets;
        public List<CurrencyMarket> MarketsList
        {
            get => _marketsList;
        }
        public ICommand OnMainCommand { get;}
        public CryptocurrencyInfoViewModel(NavigationStore _navigationStore)
        {
            _currencyData = new CurrencyInfo(MainPageViewModel.GetSearchField());
            new CurrencyMarket(MainPageViewModel.GetSearchField());
            OnMainCommand = new NavigateOnMainCommand(_navigationStore);
        }
    }
}
