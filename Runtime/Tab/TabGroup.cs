// Author: wuchenyang(shpkng@gmail.com)

using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace FF.UI
{
    public class TabGroup : MonoBehaviour
    {
        [SerializeField] private Transform tabRoot;
        [SerializeField] private List<TabItem> tabItems;

        public TabItem GetTabItem(int id)
        {
            return tabItems.FirstOrDefault(tabItem => tabItem.id == id);
        }

        public bool AddTabItem(int id, TabItem item, int index = -1, bool forceReplace = false)
        {
            bool hasId = tabItems.Any(tabItem => tabItem.id == id);

            if (!hasId)
            {
                tabItems.Add(item);
                return true;
            }
            if (!forceReplace)
                return false;
            RemoveTabItem(id);
            return AddTabItem(id, item, index, forceReplace);
        }

        public bool RemoveTabItem(int id)
        {
            return tabItems.RemoveAll(item => item.id == id) > 0;
        }
    }
}