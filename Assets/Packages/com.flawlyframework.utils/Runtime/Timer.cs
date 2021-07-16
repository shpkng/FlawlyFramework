// Author: wuchenyang(shpkng@gmail.com)

using System;
using FF.Collections;
using UnityEngine;

namespace FF.Utils
{
    public class UpdatePair
    {
        public float counter, tickInterval;
        public Action<float> callback;
    }

    public class Timer : Singleton<Timer>
    {
        private static MarkedSwapList<UpdatePair> updates =
            new MarkedSwapList<UpdatePair>(64);

        private static MarkedSwapList<UpdatePair> fixedUpdates =
            new MarkedSwapList<UpdatePair>(64);

        private static MarkedSwapList<UpdatePair> lateUpdates =
            new MarkedSwapList<UpdatePair>(64);

        public static void Init()
        {
            Instance.Reset();
        }

        private void Reset()
        {
            Instance.Reset();
        }

        public static int OnUpdate(Action<float> callback, float delta = 0)
        {
            return updates.Add(new UpdatePair {tickInterval = delta, callback = callback});
        }

        public static int OnFixedUpdate(Action<float> callback)
        {
            return fixedUpdates.Add(new UpdatePair {callback = callback});
        }

        public static int OnLateUpdate(Action<float> callback, float delta = 0)
        {
            return lateUpdates.Add(new UpdatePair {tickInterval = delta, callback = callback});
        }

        public static bool RemoveUpdateListener(int token)
        {
            return updates.Remove(token);
        }

        public static bool RemoveFixedUpdateListener(int token)
        {
            return fixedUpdates.Remove(token);
        }

        public static bool RemoveLateUpdateListener(int token)
        {
            return lateUpdates.Remove(token);
        }

        private void Update()
        {
            DoUpdate(updates, Time.deltaTime);
        }

        private void FixedUpdate()
        {
            DoUpdate(fixedUpdates, 0);
        }

        private void LateUpdate()
        {
            DoUpdate(lateUpdates, Time.deltaTime);
        }

        private void DoUpdate(MarkedSwapList<UpdatePair> update, float delta)
        {
            foreach (var pair in update.list)
            {
                pair.counter += delta;
                if (pair.counter < pair.tickInterval)
                    continue;
                pair.counter -= pair.tickInterval;
                pair.callback.Invoke(delta);
            }
        }
    }
}