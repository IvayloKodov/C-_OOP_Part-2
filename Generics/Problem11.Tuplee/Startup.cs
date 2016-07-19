using System;

namespace Problem11.Tuplee
{
    class Startup
    {
        static void Main(string[] args)
        {
            string[] personAndAdres = Console.ReadLine().Split(new char[] { });
            Tuplee<string, string> tuple = new Tuplee<string, string>(personAndAdres[0]+ " "+ personAndAdres[1], personAndAdres[2]);
            Console.WriteLine(tuple);

            string[] personBeer = Console.ReadLine().Split(new char[] { });
            Tuplee<string, int> personBeers = new Tuplee<string, int>(personBeer[0], int.Parse(personBeer[1]));
            Console.WriteLine(personBeers);

            string[] intDouble = Console.ReadLine().Split(new char[] { });
            Tuplee<int, double> intDoubleTuplee = new Tuplee<int, double>(int.Parse(intDouble[0]), double.Parse(intDouble[1]));
            Console.WriteLine(intDoubleTuplee);
        }
    }
}