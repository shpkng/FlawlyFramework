using System.Collections.Generic;

namespace FF.I18N
{
    public static class LocalizationManager
    {
        private static int defaultCollectionSize = 128;
        private static List<ILocalizable> _localizables;
        public static void Init()
        {
            _localizables = new List<ILocalizable>(defaultCollectionSize);
        }

        public static void Init(ICustomLoader customLoader)
        {
            throw new System.NotImplementedException();
        }

        public static void Release()
        {
            throw new System.NotImplementedException();
        }

        public static void SetLanguage(bool forceUpdate)
        {
            throw new System.NotImplementedException();
        }

        public static void SetLoader(ICustomLoader customLoader)
        {
            throw new System.NotImplementedException();
        }

        public static void ForceUpdate()
        {
            throw new System.NotImplementedException();
        }
    }
}