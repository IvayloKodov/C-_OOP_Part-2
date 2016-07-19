using Problem7.FoodShortage.Interface;

namespace Problem7.FoodShortage
{
    public class Person :Citizen ,IId, IBirthday
    {
        public Person(string name, int age, string id,string birthday) : base(name, age)
        {
            this.Id = id;
            this.Birthday = birthday;
        }

        public string Id { get; }
        public string Birthday { get; }

        public override void BuyFood()
        {
            base.Food+=10;
        }
    }
}