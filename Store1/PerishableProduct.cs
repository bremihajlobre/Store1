using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store1
{
    class PerishableProduct : Product
    {
        protected DateTime expirationDate;

        public PerishableProduct(String name, String brand, double price,  double quantity, DateTime expirationDate)
            : base(name, brand, price, quantity)
        {
            this.expirationDate = expirationDate;
        }
        public override string ToString()
        {
            return $"{name} {brand} \n${price} X {quantity} = ${price * quantity}";
        }

        protected override void CalculateValues()
        {
            if (this.discountedPrice == 0)
            {
                bool isFinalDay = DateTime.Today == expirationDate;
                bool isFiveDaysFromNow = DateTime.Today.AddDays(-5) > expirationDate;

                discount = isFinalDay ? 50 : isFiveDaysFromNow ? 10 : 0;

                this.discountedPrice = Math.Round(this.price * (100 - discount) / 100, 2);
            }
                
        }
    }
}
