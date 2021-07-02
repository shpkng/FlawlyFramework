// Author: wuchenyang(shpkng@gmail.com)

using UnityEngine;

namespace FF.Utils
{
    public static class ColorUtils
    {
        public static Color HexToColor(string hex)
        {
            if (ColorUtility.TryParseHtmlString(hex, out Color color))
                return color;
            return Color.white;
        }
    }
}