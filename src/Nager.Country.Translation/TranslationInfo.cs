namespace Nager.Country.Translation
{
    /// <summary>
    /// TranslationInfo
    /// </summary>
    public class TranslationInfo
    {
        /// <summary>
        /// LanguageCode
        /// </summary>
        public LanguageCode LanguageCode { get; }
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// TranslationInfo
        /// </summary>
        /// <param name="languageCode"></param>
        /// <param name="name"></param>
        public TranslationInfo(LanguageCode languageCode, string name)
        {
            this.LanguageCode = languageCode;
            this.Name = name;
        }
    }
}
