namespace FF.I18N
{
    public interface ILocalizer
    {
        string key { get; set; }
        void SetParam(params object[] args);
        void Localize();
        void ForceLocalize(string languageOrCode);
    }
}