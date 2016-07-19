using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3.Ferrari
{
    public class Startup
    {
        public static void Main()
        {
            string ferrariName = typeof(Ferrari).Name;
            string iCarInterfaceName = typeof(ICar).Name;

            bool isCreated = typeof(ICar).IsInterface;
            if (!isCreated)
            {
                throw new Exception("No interface ICar was created");
            }

            string driverName = Console.ReadLine();
            Ferrari ferrari  = new Ferrari(driverName);
            Console.WriteLine($"{ferrari.Model}/{ferrari.PushBrakes()}/{ferrari.PushTheGas()}/{ferrari.Driver}");
        }
    }
}
