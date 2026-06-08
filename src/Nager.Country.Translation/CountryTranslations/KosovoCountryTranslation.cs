namespace Nager.Country.Translation.CountryTranslations
{
    /// <summary>
    /// Kosovo (partially recognized; not a UN member state)
    /// </summary>
    public class KosovoCountryTranslation : ICountryTranslation
    {
        /// <inheritdoc/>
        public TranslationInfo[] Translations =>
        [
            new TranslationInfo(LanguageCode.DE, "Kosovo"),
            new TranslationInfo(LanguageCode.EN, "Kosovo"),
            new TranslationInfo(LanguageCode.ES, "Kosovo"),
            new TranslationInfo(LanguageCode.FR, "Kosovo"),
            new TranslationInfo(LanguageCode.HI, "कोसोवो"),
            new TranslationInfo(LanguageCode.IT, "Kosovo"),
            new TranslationInfo(LanguageCode.NL, "Kosovo"),
            new TranslationInfo(LanguageCode.NB, "Kosovo"),
            new TranslationInfo(LanguageCode.NO, "Kosovo"),
            new TranslationInfo(LanguageCode.NN, "Kosovo"),
            new TranslationInfo(LanguageCode.PL, "Kosowo"),
            new TranslationInfo(LanguageCode.PT, "Kosovo"),
            new TranslationInfo(LanguageCode.RO, "Kosovo"),
            new TranslationInfo(LanguageCode.TR, "Kosova"),
            new TranslationInfo(LanguageCode.UK, "Косово"),
        ];
    }
}
