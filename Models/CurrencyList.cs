using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Security.Policy;
using System.IO;

namespace CryptocurrencyApp.Models
{
    internal class CurrencyList
    {
        private static List<string> CryptocurrencyList = new List<string>(); 
        public CurrencyList()
        {
            string ResponseString = "";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://api.coincap.io/v2/assets");
            request.Method = "GET";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            var stream = response.GetResponseStream();           
            if (stream != null) 
                ResponseString = new StreamReader(stream).ReadToEnd();
            var json = JObject.Parse(ResponseString)["data"];
            foreach ( var item in json)
                CryptocurrencyList.Add(item["id"].ToString());
            
        }
        public static List<string> GetList()
        {
            return CryptocurrencyList;
        }
        public static bool Contains(string value)
        {
            return CryptocurrencyList.Contains(value);
        }
        public List<string> GetTop10Currency()
        {
            return CryptocurrencyList.Take(10).ToList();
        }

    }
}
