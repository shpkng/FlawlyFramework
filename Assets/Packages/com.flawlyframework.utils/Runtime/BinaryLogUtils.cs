﻿// Author: wuchenyang(shpkng@gmail.com)

using System;
using System.Collections.Generic;

namespace FF.Utils
{
    public static class BinaryLogUtils
    {
        public static long LogAt(this ref long log, int pos) => log |= (uint)(1 << pos);

        public static long RemoveLogAt(this ref long log, int pos) => log ^= (1 << pos);

        public static bool IsLogged(this long log, int pos) => ((1 << pos) & log) != 0;

        public static bool IsLogFull(this long log, int length) => log >= ((1 << length) - 1);

        /// <summary>
        /// Make sure the list's length don't exceed the max digit count of long.
        /// </summary>
        /// <param name="list">data source</param>
        /// <param name="tester">check if an item should be logged</param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static long CreateLogFrom<T>(IList<T> list, Func<T, bool> tester)
        {
            long result = 0;
            for (var i = 0; i < list.Count; i++)
                if (tester(list[i]))
                    result.LogAt(i);

            return result;
        }
    }
}