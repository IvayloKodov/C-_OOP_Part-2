namespace Problem6.BirthdayCelebrations
{
    public class Robot:IId,IName
    {
        public Robot(string name, string id )
        {
            Id = id;
            Name = name;
        }

        public string Id { get; set; }
        public string Name { get; set; }
    }
}