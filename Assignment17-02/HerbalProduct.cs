using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17_02
{
    public class HerbalProduct:Product
    {
        string herbsUsed;
        DateTime mfgDate;
        DateTime expDate;
        public HerbalProduct()
        {
            herbsUsed = "not given";
            mfgDate = DateTime.Now;
            expDate = DateTime.Now;
        }

        public override void Register()
        {
            base.Register();
            Console.WriteLine("Enter herbs used");
            herbsUsed = Console.ReadLine();
            Console.WriteLine("Enter Manufacture Date");
            mfgDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter Expiry Date");
            expDate = DateTime.Parse(Console.ReadLine());
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine("Herbs Used in Product:\t" + herbsUsed);
            Console.WriteLine("Product Mfg Date:\t"+ mfgDate.ToShortDateString());
            Console.WriteLine("Product Exp. Date:\t"+ expDate.ToShortDateString());
        }
    }
}
