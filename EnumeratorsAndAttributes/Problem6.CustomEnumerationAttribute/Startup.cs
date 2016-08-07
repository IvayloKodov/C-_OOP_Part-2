using System;

namespace Problem6.CustomEnumerationAttribute
{
    class Startup
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Type type = null;
            if (input=="Rank")
            {
                type = typeof(CardRank);
            }
            else
            {
                type = typeof(CardSuit);
            }

            var attributes = type.GetCustomAttributes(false);
            foreach (TypeAttribute attribute in attributes)
            {
                Console.WriteLine(attribute);
            }
        }
    }
}
