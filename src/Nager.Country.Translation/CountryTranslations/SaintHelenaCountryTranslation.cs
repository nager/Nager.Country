namespace Nager.Country.Translation.CountryInfos
{
    /// <summary>
    /// Saint Helena
    /// </summary>
    public class SaintHelenaCountryTranslation : ICountryTranslation
    {
        public Translation[] Translations => new[]
        {
            new Translation(LanguageCode.DE, "St. Helena"),
            new Translation(LanguageCode.FR, "Sainte-Hélène"),
            new Translation(LanguageCode.ES, "Santa Elena"),
            new Translation(LanguageCode.EN, "Saint Helena"),
            new Translation(LanguageCode.NL, "Saint Helena"),
            new Translation(LanguageCode.RU, "Острова Святой Елены, Вознесения и Тристан-да-Кунья"),
        };
        
    }
}
