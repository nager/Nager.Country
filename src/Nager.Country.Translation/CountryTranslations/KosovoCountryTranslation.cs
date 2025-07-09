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
            new TranslationInfo(LanguageCode.DE, "Kosovo"),
            new TranslationInfo(LanguageCode.EN, "Kosovo"),
            new TranslationInfo(LanguageCode.ES, "Kosovo"),
            new TranslationInfo(LanguageCode.FR, "Kosovo"),
            new TranslationInfo(LanguageCode.IT, "Kosovo"),
            new TranslationInfo(LanguageCode.NL, "Kosovo"),
            new TranslationInfo(LanguageCode.PL, "Kosowo"),
            new TranslationInfo(LanguageCode.PT, "Kosovo"),
        };
    }
}
