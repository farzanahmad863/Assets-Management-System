using System;

namespace Assets_Management_System
{
    internal class App
    {
        static AssetContext context = new AssetContext();
        public App()
        {
        }
        public void Run()
        {
            MainMenu();
        }

        private void MainMenu()
        {
            Header("Huvudmeny");
            Console.WriteLine("\nVad vill du?");
            Console.WriteLine("a) Gå till huvudmeny");
            Console.WriteLine("b) Skapa en ny tillgång/resurs");
            Console.WriteLine("c) Uppdatera en tillgång/resurs");
            Console.WriteLine("D) Ta bort en tillgång/resurs");
            Console.WriteLine("E) Hitta en tillgång/resurs");
            ConsoleKey command = Console.ReadKey(true).Key;
            if (command == ConsoleKey.A)
                MainMenu();
            
            if (command == ConsoleKey.B)
                PageCreateAsset();
            /*
            if (command == ConsoleKey.C)
                PageUpdatePost();

            if (command == ConsoleKey.D)
                PageDeleteAsset();

            if (command == ConsoleKey.E)
                PageReadAsset();
            */
        }

        private void PageCreateAsset()
        {
            Header("Skapa");
            Console.WriteLine("Skriv model:");
            string model=Console.ReadLine();
            Console.WriteLine("Skriv inköpsdatum så här MM/DD/YYYY::");
            DateTime purchaseDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Skriv pris:");
            int price = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv kontor:");
            string officeName=Console.ReadLine();
            Console.WriteLine("Skriv valuta: SEK, USD eller EUR");
            string currency=Console.ReadLine();
            Console.WriteLine("Skriv valutakurs:");
            double exchangeRate= double.Parse(Console.ReadLine());
            Console.WriteLine("Välja tillgång/resurs som du vill skapa:");
            Console.WriteLine("a) Mobiltelefon");
            Console.WriteLine("b) Dator");
            ConsoleKey assetType = Console.ReadKey(true).Key;
            if (assetType== ConsoleKey.A)
            {
                var MobilePhone = new MobilePhone()
                {
                    ModelName = model,
                    PurchaseDate = purchaseDate,
                    Price = price,
                    Office=new Office(officeName),
                    Currency = currency,
                    ExchangeRate = exchangeRate
                };
                context.MobilePhones.Add(MobilePhone);
                context.SaveChanges();
            }
            else if (assetType == ConsoleKey.B)
            {
                var LaptopComputer = new LaptopComputer()
                {
                    ModelName = model,
                    PurchaseDate = purchaseDate,
                    Price = price,
                    Office = new Office(officeName),
                    Currency = currency,
                    ExchangeRate = exchangeRate
                };
                context.LaptopComputers.Add(LaptopComputer);
                context.SaveChanges();
            }
            Console.Write("tillgång/resurs skapat.");
            Console.ReadLine();
            MainMenu();
        }

        private void Header(string text)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine(text.ToUpper());
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        
    }
}