// Author: wuchenyang(shpkng@gmail.com)

namespace FF.I18N
{
    public class DefaultLoader : ICustomLoader
    {
        public bool Init(object languageData)
        {
            return true;
        }

        public object Get(string key, params object[] args)
        {
            return null;
        }
    }
}