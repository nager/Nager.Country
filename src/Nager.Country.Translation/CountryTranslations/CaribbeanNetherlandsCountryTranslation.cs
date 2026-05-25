namespace Nager.Country.Translation.CountryTranslations
{
    /// <summary>
    /// Caribbean Netherlands
    /// </summary>
    public class CaribbeanNetherlandsCountryTranslation : ICountryTranslation
    {
        /// <inheritdoc/>
        public TranslationInfo[] Translations => new[]
        {
            new TranslationInfo(LanguageCode.DE, "Caribbean Netherlands"),
            new TranslationInfo(LanguageCode.EN, "Caribbean Netherlands"),
            new TranslationInfo(LanguageCode.ES, "Caribbean Netherlands"),
            new TranslationInfo(LanguageCode.FR, "Caribbean Netherlands"),
            new TranslationInfo(LanguageCode.HI, "कैरिबियन नीदरलैंड"),
            new TranslationInfo(LanguageCode.IT, "Caribbean Netherlands"),
            new TranslationInfo(LanguageCode.KO, "네덜란드령 카리브"),
            new TranslationInfo(LanguageCode.NL, "Caribisch Nederland"),
        };

    }
}
