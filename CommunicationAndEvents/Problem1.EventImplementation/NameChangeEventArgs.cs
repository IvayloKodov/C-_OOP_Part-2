using System;

namespace Problem1.EventImplementation
{
    public class NameChangeEventArgs : EventArgs
    {
        private string name;

        public NameChangeEventArgs(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }
    }
}