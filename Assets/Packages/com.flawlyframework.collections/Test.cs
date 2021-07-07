// Author: wuchenyang(shpkng@gmail.com)

using System;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;
using Random = UnityEngine.Random;

namespace FF.Collections
{
    public class Test : MonoBehaviour
    {
        private void Start()
        {
            var dic = new Dictionary<string, Action>();
            for (int i = 0; i < 100000; i++)
            {
                var e = i;
                dic.Add(i.ToString(), () => { });
            }

            var marked = new MarkedSwapList<Action>();
            for (int i = 0; i < 100000; i++)
            {
                var e = i;
                marked.Add(() => { });
            }

            Stopwatch sw = Stopwatch.StartNew();
            foreach (var pair in dic)
            {
                pair.Value.Invoke();
            }

            sw.Stop();
            Debug.LogError(sw.ElapsedMilliseconds);
            sw.Reset();
            Debug.LogError(sw.ElapsedMilliseconds);
            sw.Restart();
            var list = marked.list;
            for (int i = 0; i < marked.Count; i++)
            {
                list[i].Invoke();
            }

            sw.Stop();
            Debug.LogError(sw.ElapsedMilliseconds);
        }

        private static void NewMethod()
        {
            var swap = new SwapList<int>();
            var marked = new MarkedSwapList<string>();
            var list = marked.list;
            for (int i = 0; i < 50000; i++)
            {
                swap.Add(marked.Add(i.ToString()));
            }

            for (int i = 0; i < 25000; i++)
            {
                var index = Random.Range(0, swap.Count);
                var token = swap[index];
                marked.Remove(token);
                swap.RemoveAt(index);
            }

            Debug.LogError(list.Count);

            foreach (var str in marked.list)
            {
                Debug.Log(str);
            }

            for (int i = 0; i < 25000; i++)
            {
                swap.Add(marked.Add(i.ToString()));
            }


            for (int i = 0; i < 50000; i++)
            {
                var index = Random.Range(0, swap.Count);
                var token = swap[index];
                marked.Remove(token);
                swap.RemoveAt(index);
            }
        }
    }
}