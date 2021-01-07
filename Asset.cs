using System;
using System.Collections.Generic;
using System.Text;

namespace Assets_Management_System
{
    abstract class Asset
    {
        public DateTime PurchaseDate { get; set; }
        public int Price { get; set; }
        public string ModelName { get; set; }


        
    }
}
