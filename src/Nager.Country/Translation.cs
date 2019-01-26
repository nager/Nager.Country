namespace Nager.Country
{
    public class Translation
    {
        public LanguageCode LanguageCode { get; }
        public string Name { get; }

        public Translation(LanguageCode languageCode, string name)
        {
            this.LanguageCode = languageCode;
            this.Name = name;
        }
    }
}
