using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem9.TrafficLights
{
    class Startup
    {
        static void Main()
        {
            List<Lights> startLights = 
                Console.ReadLine()
                .Split(new []{' '},StringSplitOptions.RemoveEmptyEntries)
                .Select(x=>(Lights)Enum.Parse(typeof(Lights),x,true))
                .ToList();

            TrafficLight trafficLight= new TrafficLight(startLights);

            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < startLights.Count; j++)
                {
                    trafficLight.ChangeLight(j);
                }
                Console.WriteLine(trafficLight);
            }
        }
    }
}