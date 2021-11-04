using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store1
{
    public enum Size
    {
        XS,
        S,
        M,
        L,
        XL
    }
    class Clothing : Product
    {
        private Size size;
        private String color;

        public Clothing(String name, String brand, double price, double quantity, Size size, String color)
            : base(name, brand, price, quantity)
        {
            this.size = size;
            this.color = color;
        }
        public override string ToString()
        {
            return $"{name} {brand} {size} {color} \n${price} X {quantity} = ${price*quantity}";
        }

        protected override void CalculateValues()
        {
            if (this.discountedPrice == 0)
            {
                bool isWorkingDay = DateTime.Today.DayOfWeek > DayOfWeek.Sunday && DateTime.Today.DayOfWeek < DayOfWeek.Saturday;

                discount = isWorkingDay ? 10 : 0;

                this.discountedPrice = Math.Round(this.price * (100-discount)/100, 2);
            }
        }
    }
}
