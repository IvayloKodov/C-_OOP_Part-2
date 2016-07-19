namespace Problem9.CollectionHierarchy
{
    public class AddRemoveCollection<T> : MainList<T>, IRemovable<T>
    {
        public AddRemoveCollection()
        {
        }

        public T Remove()
        {
            var item = base.List[base.List.Count-1];
            base.List.RemoveAt(base.List.Count-1);
            return item;
        }
    }
}