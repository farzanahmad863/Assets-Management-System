using System;

namespace Assets_Management_System
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            LaptopComputer MacBook = new LaptopComputer(DateTime.Today, 1200, "Macbook Pro");
            //Console.WriteLine(MacBook.PurchaseDate);
            LaptopComputer Asus = new LaptopComputer(DateTime.Today, 1200, "Vivobook");
            LaptopComputer Lenovo = new LaptopComputer(DateTime.Today, 1200, "Ideapad");
            MobilePhone Iphone = new MobilePhone(DateTime.Today, 1200, "Iphone 12");
            MobilePhone Samsung = new MobilePhone(DateTime.Today, 1200, "Galaxy s20");
            MobilePhone Nokia = new MobilePhone(DateTime.Today, 1200, "Nokia 5.8");


        }
        
        
    }
}
