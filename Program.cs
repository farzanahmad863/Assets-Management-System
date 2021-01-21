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
            List<Asset> assets = PrepareAssets();
            List<ExchangeRate> exchangeRates = PrepareExchangeRates();
            assets = SortAssets(assets);
            PrintHeader();
            PrintData(assets, exchangeRates);
            Console.ReadLine();
        }

        private static void PrintData(List<Asset> assets, List<ExchangeRate> exchangeRates)
        {
            assets.ForEach(asset => PreparePrintDataLine(asset, exchangeRates));
        }

        private static void PreparePrintDataLine(Asset asset, List<ExchangeRate> exchangeRates)
        {
            int daysWarning = 913; //Approx 30 months 
            int daysAlarm = 1004;  //Approx 33 months 
            TimeSpan diff = DateTime.Now - asset.PurchaseDate;
            DecideForegroundColor(daysWarning, daysAlarm, diff);
            double usdRateToday = exchangeRates.Where(exchangeRate => exchangeRate.Currency == asset.Currency).Select(ex => ex.Rate).FirstOrDefault();
            PrintDataLine(asset, usdRateToday);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void PrintDataLine(Asset asset, double usdRateToday)
        {
            Console.WriteLine(
                            Tab(asset.ModelName) +
                            Tab(asset.Office.Name) +
                            Tab(asset.PurchaseDate.ToShortDateString()) +
                            Tab(asset.Price.ToString("0.##")) +
                            Tab(asset.Currency) +
                            Tab((asset.Price * usdRateToday).ToString("0.##"))
                            );
        }

        private static void DecideForegroundColor(int daysWarning, int daysAlarm, TimeSpan diff)
        {
            if (diff.Days > daysAlarm)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (diff.Days > daysWarning)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        private static void PrintHeader()
        {
            Console.WriteLine(
                Tab("Brand") +
                Tab("Office") +
                Tab("Purchase Date") +
                Tab("Price") +
                Tab("Currency") +
                Tab("In USD today")
                );
            Console.WriteLine(
                Tab("-----") +
                Tab("------") +
                Tab("-------------") +
                Tab("-----") +
                Tab("---------") +
                Tab("------------")
                );
        }

        private static string Tab(string input)
        {
            return input.PadRight(14);
        }

        private static List<Asset> SortAssets(List<Asset> assets)
        {
            assets = assets.OrderBy(asset => asset.GetType().ToString()).ThenBy(asset => asset.PurchaseDate).ToList();

            return assets;
        }

        private static List<ExchangeRate> PrepareExchangeRates()
        {
            return new List<ExchangeRate>
            {
                new ExchangeRate("USD",1.00),
                new ExchangeRate("SEK",0.12),
                new ExchangeRate("EUR",1.21)
            };
        }

        private static List<Asset> PrepareAssets()
        {
            return new List<Asset>()
            {
                new MobilePhone(new DateTime(2020, 03, 23), 1800, "Iphone 12", new Office("london"), "dollar", 1.45),
                new MobilePhone(new DateTime(2010, 2, 08), 1000, "Samsung Galaxy s20", new Office("london"), "dollar", 1.45),
                new MobilePhone(new DateTime(2019, 09, 04), 1700, "Nokia 5.8", new Office("london"), "dollar", 1.45),
                new LaptopComputer(new DateTime(2013, 09, 12), 1300, "Asus Vivobook", new Office("london"), "dollar", 1.45),
                new LaptopComputer(new DateTime(2011, 04, 14), 1600, "Lenovo Ideapad", new Office("london"), "dollar", 1.45),
                new LaptopComputer(new DateTime(2017, 04, 16), 1400, "Macbook Pro", new Office("london"), "dollar", 1.45)
            };   
        }
    }
}
