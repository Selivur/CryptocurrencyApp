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
        private List<string> _topList = CurrencyTopList.GetList();
        public List<string> TopList
        {
            get => _topList;
            set
            {
                _topList = value;
                OnPropertyChanged();
            }
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
            return _searchField;
        }
        public ICommand SearchCommand { get;}
    }
}
