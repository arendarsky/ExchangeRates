using ExchangeRates.Client.DataStorages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExchangeRates.Client.Models
{
    public class HomePageViewModel
    {
        public string Name { get; set; }
        public double Value { get; set; }
        public double SetValue { get; set; }
        public bool IsShortNames { get; set; }
        public string NameOrCharCode { get; set; }
        public List<Valute> Valutes => Valutes ?? new Repository().Valutes;

        public HomePageViewModel()
        {
            NameOrCharCode = "Name";
        }
    }
}