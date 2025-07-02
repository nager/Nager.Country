namespace Nager.Country.Translation.CountryTranslations
{
    /// <summary>
    /// Kosovo (partially recognized; not a UN member state)
    /// </summary>
    public class KosovoCountryTranslation : ICountryTranslation
    {
        /// <inheritdoc/>
        public TranslationInfo[] Translations => new []
        {
            new TranslationInfo(LanguageCode.EN, "Kosovo"),
            new TranslationInfo(LanguageCode.DE, "Kosovo"),
        };
    }
}
