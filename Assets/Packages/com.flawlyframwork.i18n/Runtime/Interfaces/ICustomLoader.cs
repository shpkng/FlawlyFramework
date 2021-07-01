namespace FF.I18N
{
    public interface ICustomLoader
    {
        bool Init(object languageData);
        object Get(string key, params object[] args);
    }
}