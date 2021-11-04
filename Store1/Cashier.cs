using System;

namespace Store1
{
    class Cashier
    {
        static void Main(string[] args)
        {
            Cart c = new Cart();
            c.AddProduct(new Appliance("TV", "Samsung", 3000, 4, "T-1", DateTime.Today, 30));
            c.AddProduct(new Beverage("Water", "Rosa", 50, 5, DateTime.Today));
            c.AddProduct(new Clothing("Shirt", "Tom Ford", 1900, 1, Size.M, "white"));
            c.AddProduct(new Food("Burger", "Kod Lafa", 250, 5, DateTime.Today));

            c.PrintReceipt();
        }
    }
}
