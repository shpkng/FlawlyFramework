// Author: wuchenyang(shpkng@gmail.com)

using System.Collections.Generic;

namespace FF.Collections
{
    public class SwapList<T> : List<T>
    {
        public SwapList() : base()
        {
        }

        public SwapList(int defaultCollectionSize) : base(defaultCollectionSize)
        {
        }

        public SwapList(IEnumerable<T> collection) : base(collection)
        {
        }

        public new void RemoveAt(int index)
        {
            Swap(index, Count - 1);
            base.RemoveAt(this.Count - 1);
        }

        public void Swap(int a, int b)
        {
            var temp = this[a];
            this[a] = this[b];
            this[b] = temp;
        }
    }
}