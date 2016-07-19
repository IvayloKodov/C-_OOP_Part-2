using Problem7.FoodShortage.Interface;

namespace Problem7.FoodShortage
{
    public abstract class Citizen : IBuyer
    {
        private string name;
        private int age;

        protected Citizen(string name, int age )
        {
            this.Name = name;
            this.Age = age;
            this.Food = 0;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public abstract void BuyFood();
        public int Food { get; protected set; }
    }
}