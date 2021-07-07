// Author: wuchenyang(shpkng@gmail.com)

using System.Collections.Generic;

namespace FF.UI.Management
{
    public static partial class UIManager
    {
        public static bool Open(FUI ui)
        {
            return true;
        }

        public static bool Close(FUI ui)
        {
            return true;
        }
    }

    public static partial class UIManager
    {
        private static readonly Dictionary<string, FUI> dic = new Dictionary<string, FUI>();

        public static bool Open(string name)
        {
            if (!dic.ContainsKey(name))
                return false;
            return Open(dic[name]);
        }

        public static bool Close(string name)
        {
            if (!dic.ContainsKey(name))
                return false;
            return Close(dic[name]);
        }
    }
}