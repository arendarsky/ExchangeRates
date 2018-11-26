using ExchangeRates.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ExchangeRates.Client.Helpers;

namespace ExchangeRates.Client.DataStorages
{
    public class Repository
    {
        List<Valute> _valutes;
        bool _loaded;
        public List<Valute> Valutes
        {
            get
            {
                if (_loaded)
                    return _valutes;
                _valutes = RequestHelper.GetCurrentRates();
                _loaded = true;
                return _valutes;
            }
        }
    }
}