using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store1
{
    class Food : PerishableProduct
    {
        public Food(String name, String brand, double price, double quantity, DateTime expirationDate)
            : base(name, brand, price, quantity, expirationDate)
        {

        }
    }
}
