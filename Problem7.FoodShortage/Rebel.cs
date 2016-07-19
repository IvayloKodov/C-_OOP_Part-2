using Problem7.FoodShortage.Interface;

namespace Problem7.FoodShortage
{
    public class Rebel :Citizen,IGroup
    {
        public Rebel(string name, int age,string group) : base(name, age)
        {
            this.Group = group;
        }

        public string Group { get; }

        public override void BuyFood()
        {
            base.Food += 5;
        }
    }
}