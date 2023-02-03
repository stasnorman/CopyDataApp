using CopyDataApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyDataApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program pg = new Program();
            Basket basket = new Basket();
            Console.WriteLine("В стеке:");
            Console.WriteLine(pg.GetAppleCount());

            Console.WriteLine("В куче:");
            Console.WriteLine(basket.GetBasketAppleCount());
            Console.ReadKey();
        }

        public int GetAppleCount() {
            int apple = 5;
            int orange = apple;
            orange += 20;
            return apple;
        }
    }
}
