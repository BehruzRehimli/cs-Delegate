using System;
using System.Collections.Generic;
using System.Text;

namespace Dersde_15_task
{
    internal class Product
    {
        public int No;
        public double Price;
        public byte DiscountPercent;
        public void ShowInfo()
        {
            Console.WriteLine($"NO-{No} qiymeti-{Price} endirim faizi-{DiscountPercent}");
        }
    }
}
