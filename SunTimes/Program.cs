using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime sunrise = ;
            //DateTime sunset = ;

            SunTimes daylight = new SunTimes(
                new DateTime(2015, 11, 27, 8, 15, 0),
                new DateTime(2015, 11, 27, 18, 30, 10));

            Console.WriteLine("Duration of day in minutes is: {0}", daylight.DaylightMinutes());

            ShoppingCart myCart = new ShoppingCart();

            myCart.AddProduct(20);
            myCart.AddProduct(30);

            myCart.Checkout();

            Console.ReadLine();
        }
    }

    class SunTimes
    {
        private DateTime SunriseTime { get; set; }
        private DateTime SunsetTime { get; set; }

        public SunTimes(DateTime sunrise, DateTime sunset)
        {
            SunriseTime = sunrise;
            SunsetTime = sunset;
        }

        public double DaylightMinutes()
        {
            return SunsetTime.Subtract(SunriseTime).TotalMinutes;
        } 
    }

    class ShoppingCart
    {
        public int TotalPrice { get; set; }
        public int ProductCount { get; set; }

        public void AddProduct(int price)
        {
            TotalPrice += price;
            ProductCount++;
        }

        public void Checkout()
        {
            Console.WriteLine("Total price is: " + TotalPrice);
            Console.WriteLine("Product count is: " + ProductCount);
            Console.WriteLine("Average price is: " + TotalPrice / ProductCount);
        }
    }
}
