using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HerbalProduct product = new HerbalProduct();
            product.Register();
            product.Show();
            Console.ReadKey();
        }
    }
}
