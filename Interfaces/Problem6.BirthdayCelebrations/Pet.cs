namespace Problem6.BirthdayCelebrations
{
    public class Pet:IName,IBirthday
    {
        public Pet(string name, string birthday)
        {
            Name = name;
            Birthday = birthday;
        }

        public string Name { get; set; }
        public string Birthday { get; set; }
    }
}