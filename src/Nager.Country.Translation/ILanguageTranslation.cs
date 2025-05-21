namespace Nager.Country.Translation
{
    /// <summary>
    /// Language Translation Interface
    /// </summary>
    public interface ILanguageTranslation
    {
        /// <summary>
        /// CommonName
        /// </summary>
        string CommonName { get; }

        /// <summary>
        /// OfficialName
        /// </summary>
        string OfficialName { get; }

        /// <summary>
        /// Translations
        /// </summary>
        TranslationInfo[] Translations { get; }

        /// <summary>
        /// ISO 639-1 language code
        /// </summary>
        LanguageCode LanguageCode { get; }
    }
}
