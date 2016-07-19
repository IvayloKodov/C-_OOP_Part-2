namespace Problem12.Threeuple
{
    public class ThreeUple<TKey,TValue,TInfo>
    {
        public ThreeUple(TKey key,TValue value,TInfo info)
        {
            this.Key = key;
            this.Value = value;
            this.Info = info;
        }

        public TKey Key { get;private set; }
        public TValue Value { get; private set; }
        public TInfo Info { get; private set; }

        public override string ToString()
        {
            return $"{this.Key} -> {this.Value} -> {this.Info}";
        }
    }
}