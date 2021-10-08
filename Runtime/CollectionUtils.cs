// Author: wuchenyang(shpkng@gmail.com)

using System;
using System.Collections.Generic;

namespace FF.Utils
{
    public static class CollectionUtils
    {
        public static bool Contains<T1, T2>(ICollection<T1> collection, T2 target, Func<T1, T2, bool> comparer)
        {
            foreach (var item in collection)
            {
                if (comparer(item, target))
                    return true;
            }

            return false;
        }
    }
}