namespace Problem6.BirthdayCelebrations
{
    public class Citizen:IId,IName,IBirthday
    {
        private int age;

        public Citizen(string name, int age, string id, string birthday)
        {
            Name = name;
            this.age = age;
            Id = id;
            Birthday = birthday;
        }

        public string Name { get; set; }
        public string Id { get; set; } 
        public string Birthday { get; set; }
    }
}