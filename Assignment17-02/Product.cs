using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment17_02
{
    public class Product
    {
        int pid;
        string pName;
        double pPrice;
        public Product()
        {
            pid = 0;
            pName = "not given";
            pPrice = 0;
        }
        public virtual void Register()
        {
            Console.WriteLine("Enter Product ID");
            pid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Product Name");
            pName = Console.ReadLine();
            Console.WriteLine("Enter Product Price");
            pPrice = double.Parse(Console.ReadLine());
        }
        public virtual void Show()
        {
            Console.WriteLine("Product ID: \t" + pid);
            Console.WriteLine("Product Name: \t" + pName);
            Console.WriteLine("Product Price: \t" + pPrice);
        }
    }
}
