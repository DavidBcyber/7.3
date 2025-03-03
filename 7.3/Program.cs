using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._3
{
    internal class Program
    {
        class Product
        {
            public string productID { get; set; }
            public string productName { get; set; }
            public double price { get; set; }
        }
        static void Main(string[] args)
        {
            var prodductName = Product.Select(Product => Product);
            Console.WriteLine(prodductName);

            var removeproduct = string product.remove(string product => string product);
            Console.WriteLine(removeproduct);

            var calculateTotalPrice= price.calculate(price => price);
            Console.WriteLine(calculateTotalPrice);
        }
    }
}
