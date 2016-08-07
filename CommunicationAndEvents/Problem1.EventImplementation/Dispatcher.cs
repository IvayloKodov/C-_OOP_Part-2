namespace Problem1.EventImplementation
{
    public delegate void NameChangeEventHandler(object sender,NameChangeEventArgs args);

    public class Dispatcher
    {
        private string name;
        public event NameChangeEventHandler NameChanged ;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnNameChange(new NameChangeEventArgs(value));
            }
        }

        private void OnNameChange(NameChangeEventArgs args)
        {
            if (NameChanged != null)
            {
                NameChanged(this, args);
            }
        }
    }
}