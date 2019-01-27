namespace Nager.Country.CountryInfo
{
    /// <summary>
    /// Austria
    /// </summary>
    public class AustriaInfo : ICountryInfo
    {
        public string CommonName => "Austria";
        public string OfficialName => "Republic of Austria";
        public Translation[] Translations => new[]
        {
            new Translation(LanguageCode.DE, "Österreich"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.AT;
        public Alpha3Code Alpha3Code => Alpha3Code.AUT;
        public int NumericCode => 040;
        public string[] TLD => new [] { ".at" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.WesternEurope;

        public Alpha2Code[] BorderCountrys => new Alpha2Code[]
        {
            Alpha2Code.CZ,
            Alpha2Code.DE,
            Alpha2Code.HU,
            Alpha2Code.IT,
            Alpha2Code.LI,
            Alpha2Code.SK,
            Alpha2Code.SI,
            Alpha2Code.CH,
        };

        public string[] Currencies => new [] { "EUR" };
        public string[] CallingCodes => new [] { "43" };

    }
}
