namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Saint Helena
    /// </summary>
    public class SaintHelenaInfo : ICountryInfo
    {
        public string CommonName => "Saint Helena, Ascension and Tristan da Cunha";
        public string OfficialName => "Saint Helena, Ascension and Tristan da Cunha";
        public Translation[] Translations => new[]
        {
            new Translation(LanguageCode.DE, "St. Helena"),
            new Translation(LanguageCode.FR, "Sainte-Hélène"),
            new Translation(LanguageCode.ES, "Santa Elena"),
            new Translation(LanguageCode.EN, "Saint Helena"),
            new Translation(LanguageCode.NL, "Saint Helena"),
            new Translation(LanguageCode.RU, "Острова Святой Елены, Вознесения и Тристан-да-Кунья"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.SH;
        public Alpha3Code Alpha3Code => Alpha3Code.SHN;
        public int NumericCode => 654;
        public string[] TLD => new[] { ".sh", ".ac" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.WesternAfrica;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.AR,
            Alpha2Code.BR,
            Alpha2Code.CL,
            Alpha2Code.PY,
            Alpha2Code.PE,
        };

        public string[] Currencies => new[] { "SHP", "GBP" };
        public string[] CallingCodes => new[] { "290", "247" };
    }
}
