namespace Problem9.CollectionHierarchy
{
    public class AddCollection<T> : MainList<T>
    {
        public AddCollection()
        {
        }

        public override int Add(T element)
        {
            base.List.Add(element);
            return base.List.Count - 1;
        }
    }
}