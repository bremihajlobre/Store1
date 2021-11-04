using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store1
{
    public abstract class Product
    {
        protected String name;
        protected String brand;
        protected double price;
        protected double discountedPrice;
        protected double discount;
        protected double quantity;

        public Product(String name, String brand, double price, double quantity)
        {
            this.name = name;
            this.brand = brand;
            this.price = Math.Round(price, 2);
            this.quantity = Math.Round(quantity,2);
        }

        protected abstract void CalculateValues();

        public double DiscountedPrice { get => discountedPrice * quantity; }

        public double CalculatePrice()
        {
            CalculateValues();
            return this.quantity * this.price;
        }

        public void PrintPrice()
        {
            CalculateValues();
            Console.WriteLine(this.ToString());
            if (discountedPrice != price)
                Console.WriteLine($"#discount {discount} % -${this.quantity*(this.price - this.discountedPrice)}");
        }
    }
}
