using System.Collections;

namespace Problem4.Froggy
{
    using System.Collections.Generic;

    public class Lake<T> : IEnumerable<T> where T: class 
    {
        private List<T> stones;

        public Lake(List<T> stones)
        {
            this.stones = stones;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.stones.Count; i++)
            {
                if (i%2==0)
                {
                    yield return this.stones[i];
                }
            }

            for (int i = this.stones.Count - 1; i >= 0; i --)
            {
                if (i % 2 != 0)
                {
                    yield return this.stones[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}