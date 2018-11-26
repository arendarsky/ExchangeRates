using ExchangeRates.Client.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace ExchangeRates.Client.Helpers
{
    public class RequestHelper
    {
        public static List<Valute> GetCurrentRates()
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://www.cbr-xml-daily.ru/daily_json.js");

            httpWebRequest.ContentType = "text/json";
            httpWebRequest.Method = "GET";
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();

                RootObject response = JsonConvert.DeserializeObject<RootObject>(result);
                List<Valute> valutes = new List<Valute>();
                foreach (var v in response.Valute)
                {
                    valutes.Add(v.Value);
                }
                return valutes;
            }
        }
    }
}