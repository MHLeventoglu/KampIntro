using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class ProductManager
    {
        public void Add(Product product)
        {
            product.ProductName = "Kamera";
        }

        public void Add2(int sayi)
        {
            sayi = 99;
            Console.WriteLine(sayi+"that value came from function");
        }
    }
}
