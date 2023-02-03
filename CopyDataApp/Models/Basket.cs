using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyDataApp.Models
{
    internal class Basket
    {
        public int ItemsCount { get; set; }

        public int GetBasketAppleCount() {
            Basket apple = new Basket();
            Basket orange = new Basket();

            apple.ItemsCount = 5;
            orange.ItemsCount += 20;

            return orange.ItemsCount;
        }
    }
}
