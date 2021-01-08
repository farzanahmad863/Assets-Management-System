using System;
using System.Collections.Generic;
using System.Linq;
namespace Assets_Management_System
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Asset> CompanyAssets = new List<Asset>();
            
            
            CompanyAssets.Add(new MobilePhone(new DateTime(2008/04/14), 1800, "Iphone 12"));
            CompanyAssets.Add(new MobilePhone(DateTime.Today, 1000, "Samsung Galaxy s20"));
            CompanyAssets.Add(new MobilePhone(DateTime.Today, 1700, "Nokia 5.8"));
            CompanyAssets.Add(new LaptopComputer(DateTime.Today, 1300, "Asus Vivobook"));
            CompanyAssets.Add(new LaptopComputer(DateTime.Today, 1600, "Lenovo Ideapad"));
            CompanyAssets.Add(new LaptopComputer(DateTime.Today, 1400, "Macbook Pro"));
            CompanyAssets = CompanyAssets.OrderBy(assets => assets.GetType().ToString())
                .ThenBy(assets => assets.PurchaseDate).ToList();
            Console.WriteLine("Model Name".PadRight(25) + "Price".PadRight(25) + "Purchase Date"+ Environment.NewLine);
            foreach (var asset in CompanyAssets)
            {
                if (DateTime.Today.Subtract(asset.PurchaseDate).TotalDays>= 1005)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(asset.ModelName.PadRight(25) + asset.Price.ToString().PadRight(25) + asset.PurchaseDate.ToString("dddd, dd MMMM yyyy"));
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(asset.ModelName.PadRight(25) + asset.Price.ToString().PadRight(25) + asset.PurchaseDate.ToString("dddd, dd MMMM yyyy"));
                }
                
            }

            /*
            var query = CompanyAssets.GroupBy(asset => asset.GetType())
                  .Select(group =>group.OrderBy(asset => asset.Price));

            foreach (var group in query)
            {
                
                foreach (var asset in group)
                {
                  Console.WriteLine(asset.ModelName.PadRight(25) + asset.Price.ToString().PadRight(25) + asset.PurchaseDate.ToString("dddd, dd MMMM yyyy"));
                }
            }
            */



        }


    }
}
