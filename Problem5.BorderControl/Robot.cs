namespace Problem5.BorderControl
{
    public class Robot :IId
    {
        private string model;

        public Robot(string model, string id)
        {
            this.model = model;
            Id = id;
        }

        public string Id { get; set; }
    }
}