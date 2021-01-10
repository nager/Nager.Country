namespace Nager.Country.Translation.CountryInfos
{
    /// <summary>
    /// Caribbean Netherlands
    /// </summary>
    public class CaribbeanNetherlandsCountryTranslation : ICountryTranslation
    {
        public Translation[] Translations => new[]
        {
            new Translation(LanguageCode.EN, "Caribbean Netherlands"),
            new Translation(LanguageCode.DE, "Caribbean Netherlands"),
            new Translation(LanguageCode.NL, "Caribbean Netherlands"),
            new Translation(LanguageCode.FR, "Caribbean Netherlands"),
            new Translation(LanguageCode.ES, "Caribbean Netherlands"),
            new Translation(LanguageCode.IT, "Caribbean Netherlands"),
        };
        
    }
}
