using System;

namespace Problem3.Ferrari
{
    public class Ferrari:ICar
    {
        private const string model = "488-Spider";
        public Ferrari(string driver)
        {
            this.Driver = driver;
        }

        public string Driver { get; set; }
        public string Model => model;

        public string PushBrakes()
        {
            return "Brakes!";
        }

        public string PushTheGas()
        {
            return "Zadu6avam sA!";
        }
    }
}