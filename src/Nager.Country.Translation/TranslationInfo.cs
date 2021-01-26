namespace Nager.Country.Translation
{
    public class TranslationInfo
    {
        public LanguageCode LanguageCode { get; }
        public string Name { get; }

        public TranslationInfo(LanguageCode languageCode, string name)
        {
            this.LanguageCode = languageCode;
            this.Name = name;
        }
    }
}
