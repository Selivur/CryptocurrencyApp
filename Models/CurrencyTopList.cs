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
    internal static class CurrencyTopList
    {
        public static List<string> GetList()
        {
            List<string> CurrencyList = new List<string>();
            string ResponseString = "";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://api.coincap.io/v2/assets");
            request.Method = "GET";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            var stream = response.GetResponseStream();           
            if (stream != null) 
                ResponseString = new StreamReader(stream).ReadToEnd();
            var json = JObject.Parse(ResponseString)["data"];
            for (int i = 0; i < 10; i++)
            {
                CurrencyList.Add((string)json[i]["id"]);
            }
            return CurrencyList;
        }


    }
}
