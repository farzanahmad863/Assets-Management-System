using System;
using System.Collections.Generic;
using System.Text;

namespace Assets_Management_System
{
    class Asset
    {
        public DateTime PurchaseDate { get; set; }
        public int Price { get; set; }
        public string ModelName { get; set; }
        public Office Office { get; set; }
        public string Currency { get; set; }
        public double ExchangeRate { get; set; }
    }
}
