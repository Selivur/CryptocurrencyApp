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
    internal class CurrencyInfo
    {
        public CurrencyInfo(string currency)
        {
            string ResponseString = "";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://api.coincap.io/v2/assets"+currency);
            request.Method = "GET";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            var stream = response.GetResponseStream();
            if (stream != null)
                ResponseString = new StreamReader(stream).ReadToEnd();
            var json = JObject.Parse(ResponseString)["data"];
            Name = currency;
            Price = (float)json["supply"];
            VolumeUsd24Hr = (float)json["volumeUsd24Hr"];
            ChangePercent24Hr = (float)json["changePercent24Hr"];
        }
        public string Name { get; set; }
        public float Price { get; set; }
        public float VolumeUsd24Hr { get; set; }
        public float ChangePercent24Hr { get; set; }
    }
}
