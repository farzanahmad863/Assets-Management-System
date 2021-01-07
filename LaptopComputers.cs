using System;
using System.Collections.Generic;
using System.Text;

namespace Assets_Management_System
{
    class LaptopComputers: Asset
    {
        public LaptopComputers(DateTime purchaseDate,int price, string modelName)
        {
                PurchaseDate = purchaseDate;
                Price = price;
                ModelName = modelName;
            
        }
    }
}
