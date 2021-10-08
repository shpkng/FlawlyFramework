// Author: wuchenyang(shpkng@gmail.com)

using System.Collections.Generic;

namespace FF.Utils
{
    public class EventDispatcher
    {
        public delegate void EventHandler();

        private Dictionary<uint, EventHandler> map;

        public EventDispatcher()
        {
            map = new Dictionary<uint, EventHandler>();
        }

        ~EventDispatcher()
        {
            map = null;
        }

        public void RegisterListener(uint id, EventHandler callback)
        {
            if (!map.ContainsKey(id))
            {
                map.Add(id, delegate { });
                return;
            }

            if (map[id] == null)
            {
                map[id] = delegate { };
                return;
            }

            map[id] += callback;
        }

        public void RemoveListener(uint id, EventHandler callback)
        {
            if (!map.ContainsKey(id))
                return;
            if (map[id] == null)
            {
                map.Remove(id);
                return;
            }

            map[id] -= callback;
        }

        public void Trigger(uint id)
        {
            if (!map.ContainsKey(id))
                return;
            if (map[id] == null)
            {
                map.Remove(id);
                return;
            }

            map[id].Invoke();
        }
    }
}