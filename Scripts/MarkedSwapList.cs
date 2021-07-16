// Author: wuchenyang(shpkng@gmail.com)

using System;
using System.Collections.Generic;

namespace FF.Collections
{
    public class MarkedSwapList<T>
    {
        private List<T> _list;
        private Dictionary<int, int> tokenToIndex = new Dictionary<int, int>();
        private Dictionary<int, int> indexToToken = new Dictionary<int, int>();
        private Queue<int> recycledIndex = new Queue<int>();

        public MarkedSwapList()
        {
            _list = new List<T>();
        }

        public MarkedSwapList(int defaultCollectionSize)
        {
            _list = new List<T>(defaultCollectionSize);
        }

        public MarkedSwapList(IEnumerable<T> collection)
        {
            _list = new List<T>(collection);
        }

        public int Count => _list.Count;
        public T this[int index] => _list[index];
        public List<T> list => _list;

        public T Get(int token)
        {
            if (!tokenToIndex.ContainsKey(token))
                throw new ArgumentOutOfRangeException();
            return _list[tokenToIndex[token]];
        }

        public bool TryGet(int token, out T result)
        {
            if (!tokenToIndex.ContainsKey(token))
            {
                result = default(T);
                return false;
            }

            result = _list[tokenToIndex[token]];
            return true;
        }

        public int Add(T value)
        {
            int newIndex = _list.Count;
            int token = recycledIndex.Count == 0 ? tokenToIndex.Count : recycledIndex.Dequeue();
            _list.Add(value);
            tokenToIndex[token] = newIndex;
            indexToToken[newIndex] = token;
            return token;
        }

        public bool Remove(int token)
        {
            if (!tokenToIndex.ContainsKey(token))
                return false;
            int aIndex = tokenToIndex[token], bIndex = _list.Count - 1;
            int bToken = indexToToken[bIndex];
            var temp = _list[bIndex];
            _list[bIndex] = _list[aIndex];
            _list[aIndex] = temp;
            indexToToken.Remove(bIndex);
            bIndex = aIndex;
            tokenToIndex[bToken] = bIndex;
            indexToToken[bIndex] = bToken;
            tokenToIndex.Remove(token);
            _list.RemoveAt(_list.Count - 1);
            recycledIndex.Enqueue(token);
            return true;
        }
    }
}