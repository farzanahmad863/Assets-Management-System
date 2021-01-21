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
        public Office office { get; set; }
        public string currency { get; set; }
        public double exchangeRate { get; set; }
    }
}
