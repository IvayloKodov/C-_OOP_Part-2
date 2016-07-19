using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem12.Threeuple
{
    class Startup
    {
        static void Main()
        {
            string[] personAndTown = Console.ReadLine().Split();
            string fullName = personAndTown[0] + " " + personAndTown[1];
            string adress = personAndTown[2];
            string town = personAndTown[3];
            var personAndTownThreeTuple = new ThreeUple<string,string,string>(fullName,adress,town);
            Console.WriteLine(personAndTownThreeTuple);

            string[] personAndBeer = Console.ReadLine().Split();
            string name = personAndBeer[0];
            int beerCount = int.Parse(personAndBeer[1]);
            string drunkStatus = personAndBeer[2];
            bool isDrunk = drunkStatus == "drunk";
       
            var personAndBeerThreeTuple = new ThreeUple<string,int,bool>(name,beerCount,isDrunk);
            Console.WriteLine(personAndBeerThreeTuple);

            string[] personBank = Console.ReadLine().Split();
            string personName = personBank[0];
            double accountBalance = double.Parse(personBank[1]);
            string bankName = personBank[2];
            var personBankThreeTuple = new ThreeUple<string,double,string>(personName,accountBalance,bankName);
            Console.WriteLine(personBankThreeTuple);
        }
    }
}
