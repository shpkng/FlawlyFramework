namespace FF.I18N
{
    using Collections;
    public class DefaultLocalizeManager : ILocalizeManager
    {
        private static DefaultLocalizeManager _instance;

        public ILocalizeManager instance => _instance ??= new DefaultLocalizeManager();

        private const int defaultCollectionSize = 128;
        private static SwapList<ILocalizer> _localizables;

        public static void Init()
        {
            _localizables = new SwapList<ILocalizer>(defaultCollectionSize);
        }

        public static void Init(ICustomLoader customLoader)
        {
            
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