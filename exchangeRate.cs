using System;
using System.Collections.Generic;
using System.Text;

namespace Assets_Management_System
{
    class ExchangeRate
    {
        public string Currency { get; set; }
        public double Rate { get; set; }
        public int ExchangeRateId { get; set; }


        public ExchangeRate(string currency, double rate)
        {
            Currency = currency;
            Rate = rate;
        }

    }
}
