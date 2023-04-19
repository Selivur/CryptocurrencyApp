using CryptocurrencyApp.Models;
using CryptocurrencyApp.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptocurrencyApp.ViewModels
{
    internal class CryptocurrencyInfoViewModel : ViewModel
    {
        private readonly CurrencyInfo _currencyData;
        public string Name => _currencyData.Name;

        public string Price => "Price:\t"+_currencyData.Price.ToString();

        public string VolumeUsd24Hr => "Volume:\t"+_currencyData.VolumeUsd24Hr.ToString();
       
        public string ChangePercent24Hr => "Change:\t"+_currencyData.ChangePercent24Hr.ToString();

        public CryptocurrencyInfoViewModel()
        {

            _currencyData = new CurrencyInfo("");
        }
    }
}
