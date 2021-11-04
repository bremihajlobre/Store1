using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store1
{
    class Cart
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(Product p)
        {
            products.Add(p);
        }

        public void PrintReceipt()
        {
            Console.WriteLine("Date: " + DateTime.Now + "\n " + "\n---Products---\n");

            double subTotalSum = 0;
            double totalSum = 0;
            foreach (var product in products)
            {
                subTotalSum += product.CalculatePrice();
                totalSum += product.DiscountedPrice;
                product.PrintPrice();
                Console.WriteLine("\n");
            }
            Console.WriteLine("-----------------------------------------------------------------------------------");

            Console.Write($"\nSUBTOTAL: ${subTotalSum} \nDISCOUNT: ${totalSum - subTotalSum} \n\nTOTAL: ${totalSum}");
        }
    }
}
