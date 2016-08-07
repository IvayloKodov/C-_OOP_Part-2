using System.Collections.Generic;

namespace Problem9.TrafficLights
{
    public class TrafficLight
    {
        private List<Lights> currentTrafficLight;

        public TrafficLight(List<Lights> currentTrafficLight)
        {
            this.currentTrafficLight = currentTrafficLight;
        }

        public void ChangeLight(int index)
        {
                if (this.currentTrafficLight[index].Equals(Lights.Red))
                {
                    this.currentTrafficLight[index] = Lights.Green;
                }
                else if (this.currentTrafficLight[index].Equals(Lights.Green))
                {
                    this.currentTrafficLight[index] = Lights.Yellow;
                }
                else// Yellow
                {
                    this.currentTrafficLight[index] = Lights.Red;
                }
        }

        public override string ToString()
        {
            return $"{string.Join(" ",this.currentTrafficLight)}";
        }
    }
}