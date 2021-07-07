// Author: wuchenyang(shpkng@gmail.com)

using System;
using FF.Collections;

namespace FF.Utils
{
    public class Timer : Singleton<Timer>
    {
        private SwapList<Tuple<float, float, Action>> eventTuples = new SwapList<Tuple<float, float, Action>>(64);

        public static void Init()
        {
            Instance.Reset();
        }

        private void Reset()
        {
        }
    }
}