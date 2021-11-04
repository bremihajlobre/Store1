using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store1
{
    class Appliance : Product
    {
        private String model;
        private DateTime productionDate;
        private double weight;

        public Appliance(String name, String brand, double price, double quantity, string model, DateTime productionDate, double weight)
            : base(name, brand, price, quantity)
        {
            this.model = model;
            this.productionDate = productionDate;
            this.weight = weight;
        }
        public override string ToString()
        {
            return $"{name} {brand} {model} \n${price} X {quantity} = ${price * quantity}";
        }

        protected override void CalculateValues()
        {
            if (this.discountedPrice == 0)
            {
                bool isWorkingDay = DateTime.Today.DayOfWeek > DayOfWeek.Sunday && DateTime.Today.DayOfWeek < DayOfWeek.Saturday;

                discount = !isWorkingDay && this.price>999 ? 5 : 0;

                this.discountedPrice = Math.Round(this.price * (100 - discount) / 100, 2);
            }
        }
    }
}
