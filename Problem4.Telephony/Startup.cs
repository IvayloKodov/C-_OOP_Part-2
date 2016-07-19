using System;

namespace Problem4.Telephony
{
    public class Startup
    {
        public static void Main()
        {
            string[] numbers = Console.ReadLine().Split();
            string[] sites = Console.ReadLine().Split();

            SmartPhone smartPhone = new SmartPhone();
            foreach (var number in numbers)
            {
                smartPhone.CallingNumber(number);
            }

            foreach (var site in sites)
            {
                smartPhone.BrowseSite(site);
            }
        }
    }
}