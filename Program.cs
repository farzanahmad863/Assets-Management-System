using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
namespace Assets_Management_System
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Asset> CompanyAssets = new List<Asset>();
            
            
            CompanyAssets.Add(new MobilePhone(new DateTime(2020,03,23), 1800,"Iphone 12",new Office("london")));
            CompanyAssets.Add(new MobilePhone(new DateTime(2010,2,08), 1000, "Samsung Galaxy s20", new Office("london")));
            CompanyAssets.Add(new MobilePhone(new DateTime(2019,09,04), 1700, "Nokia 5.8", new Office("london")));
            CompanyAssets.Add(new LaptopComputer(new DateTime(2013,09,12), 1300, "Asus Vivobook", new Office("london")));
            CompanyAssets.Add(new LaptopComputer(new DateTime(2011,04,14), 1600, "Lenovo Ideapad", new Office("london")));
            CompanyAssets.Add(new LaptopComputer(new DateTime(2017,04,16), 1400, "Macbook Pro", new Office("london")));
            CompanyAssets = CompanyAssets.OrderBy(assets => assets.GetType().ToString())
                .ThenBy(assets => assets.PurchaseDate).ToList();
            
            
            Console.WriteLine("Model Name".PadRight(25) + "Price".PadRight(25) + "Purchase Date"+ Environment.NewLine);

            foreach (var asset in CompanyAssets)
            {
                if (DateTime.Today.Subtract(asset.PurchaseDate).TotalDays>= 1005)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(asset.ModelName.PadRight(25) + asset.Price.ToString().PadRight(25) + asset.PurchaseDate);
                }
               else if(DateTime.Today.Subtract(asset.PurchaseDate).TotalDays < 1005)
                    {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(asset.ModelName.PadRight(25) + asset.Price.ToString().PadRight(25) + asset.PurchaseDate);
                }
                    
                
                
            }

            
            
            
            







        }


    }
}
