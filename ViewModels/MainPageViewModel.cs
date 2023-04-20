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
    internal class MainPageViewModel : ViewModel
    {
        private readonly CurrencyList _currencyList;
        private List<string> _topList =>_currencyList.GetTop10Currency();
        public List<string> TopList
        {
            get => _topList;
        }

        private static string _searchField;
        public string SearchField
        {
            get => _searchField;
            set
            {
                _searchField = value;
                OnPropertyChanged();
            }
        }

        public static string GetSearchField()
        {
            //if (CurrencyList.GetList().Contains(_searchField))
                return _searchField;
        }
        public ICommand SearchCommand { get;}
        //private RelayCommand _searchCommand;
        //public RelayCommand SearchCommand
        //{
        //    get
        //    {
        //        return _searchCommand ?? new RelayCommand(obj =>
        //        {
        //              Paste code here(it`s a template for future)       
        //        });
        //    }
        //}
        public MainPageViewModel(NavigationStore navigationStore)
        {
            _currencyList = new CurrencyList();
            SearchCommand = new SearchCommand(navigationStore); 
        }
    }
}
