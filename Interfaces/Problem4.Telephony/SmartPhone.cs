using System;

namespace Problem4.Telephony
{
    public class SmartPhone:ICallable,IBrowsable
    {
        public SmartPhone()
        {
        }

        public void CallingNumber(string number)
        {
            bool isNumber = true;
            for (int i = 0; i < number.Length; i++)
            {
                if (!char.IsDigit(number[i]))
                {
                    isNumber = false;
                    break;
                }
            }

            if (isNumber)
            {
                Console.WriteLine($"Calling... {number}");
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }
     
        public void BrowseSite(string site)
        {
            bool isValidSite = true;
            for (int i = 0; i < site.Length; i++)
            {
                if (char.IsDigit(site[i]))
                {
                    isValidSite = false;
                    break;
                }
            }

            if (isValidSite)
            {
                Console.WriteLine($"Browsing: {site}!");
            }
            else
            {
                Console.WriteLine("Invalid URL!");
            }
        }
    }
}