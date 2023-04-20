using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CryptocurrencyApp.Models
{
    internal class CurrencyMarket
    {
        public static List<CurrencyMarket> CurrencyMarkets= new List<CurrencyMarket>();
        public string Market { get; set; }
        public string Price { get; set; }
        public CurrencyMarket(string currency)
        {
            CurrencyMarkets.Clear();
            string ResponseString = "";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://api.coincap.io/v2/assets/" + currency+"/markets");
            request.Method = "GET";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            var stream = response.GetResponseStream();
            if (stream != null)
                ResponseString = new StreamReader(stream).ReadToEnd();
            var json = JObject.Parse(ResponseString)["data"];
            foreach (var item in json)
                CurrencyMarkets.Add(new CurrencyMarket(item["exchangeId"].ToString(), item["priceUsd"].ToString())); ;
        }
        private CurrencyMarket(string market, string price)
        {
            Market = market;
            Price = price;
        }

    }
}
