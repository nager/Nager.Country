namespace Nager.Country.Translation
{
    /// <summary>
    /// ICountryTranslation
    /// </summary>
    public interface ICountryTranslation
    {
        /// <summary>
        /// Get all country translations
        /// </summary>
        TranslationInfo[] Translations { get; }
    }
}
