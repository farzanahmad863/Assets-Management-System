using System;
using System.Collections.Generic;
using System.Linq;
namespace Assets_Management_System
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");  
            //Console.WriteLine(MacBook.PurchaseDate);
            List<Asset> CompanyAssets = new List<Asset>();
            CompanyAssets.Add(new LaptopComputer(DateTime.Today, 1200, "Macbook Pro"));
            CompanyAssets.Add(new LaptopComputer(DateTime.Today, 1300, "Asus Vivobook"));
            CompanyAssets.Add(new LaptopComputer(DateTime.Today, 1100, "Lenovo Ideapad"));
            CompanyAssets.Add(new MobilePhone(DateTime.Today, 1800, "Iphone 12"));
            CompanyAssets.Add(new MobilePhone(DateTime.Today, 1000, "Samsung Galaxy s20"));
            CompanyAssets.Add(new MobilePhone(DateTime.Today, 1700, "Nokia 5.8"));
            
            foreach (Asset asset in CompanyAssets)
            {
                if (asset is LaptopComputer)
                {
                    
                    Console.WriteLine(asset.ModelName.PadRight(20) + asset.Price.ToString().PadRight(20) + asset.PurchaseDate.ToString("dddd, dd MMMM yyyy"));
                }
                else if (asset is MobilePhone)
                {
                    Console.WriteLine(asset.ModelName.PadRight(20) + asset.Price.ToString().PadRight(20) + asset.PurchaseDate.ToString("dddd, dd MMMM yyyy"));
                }

            }









        }


    }
}
