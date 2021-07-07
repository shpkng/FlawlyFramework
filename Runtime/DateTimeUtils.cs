// Author: wuchenyang(shpkng@gmail.com)

using System;

namespace FF.Utils
{
    public static class DateTimeUtils
    {
        #region Ugly Extesion Methods

        public static DateTime ToDateTime(this long timestamp) => GetDateTime(timestamp);

        #endregion

        public static DateTime utcOrigin => new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        public static long timestampNow => GetTimestamp(DateTime.Now);

        public static long GetTimestamp(DateTime dateTime) => (long) (dateTime - utcOrigin).TotalSeconds;
        
        public static DateTime GetDateTime(long timestamp) => utcOrigin + TimeSpan.FromSeconds(timestamp);
        public static long GetSecondsFromDue(long dueTime) => dueTime - timestampNow;
        public static TimeSpan GetTimeSpanFromDue(long dueTime) => TimeSpan.FromSeconds(GetSecondsFromDue(dueTime));
    }
}