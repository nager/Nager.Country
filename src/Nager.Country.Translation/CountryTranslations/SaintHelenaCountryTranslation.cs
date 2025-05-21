namespace Nager.Country.Translation.CountryTranslations
{
    /// <summary>
    /// Saint Helena
    /// </summary>
    public class SaintHelenaCountryTranslation : ICountryTranslation
    {
        /// <inheritdoc/>
        public TranslationInfo[] Translations => new[]
        {
            new TranslationInfo(LanguageCode.DE, "St. Helena"),
            new TranslationInfo(LanguageCode.FR, "Sainte-Hélène"),
            new TranslationInfo(LanguageCode.ES, "Santa Elena"),
            new TranslationInfo(LanguageCode.EN, "Saint Helena"),
            new TranslationInfo(LanguageCode.IS, "Sankti Helena"),
            new TranslationInfo(LanguageCode.NL, "Saint Helena"),
            new TranslationInfo(LanguageCode.RU, "Острова Святой Елены, Вознесения и Тристан-да-Кунья"),
			new TranslationInfo(LanguageCode.KO, "세인트헬레나"),
		};
        
    }
}
