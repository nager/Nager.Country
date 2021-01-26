using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// France
    /// </summary>
    public class FranceCountryInfo : ICountryInfo
    {
        public string CommonName => "France";
        public string OfficialName => "French Republic";
        public Alpha2Code Alpha2Code => Alpha2Code.FR;
        public Alpha3Code Alpha3Code => Alpha3Code.FRA;
        public int NumericCode => 250;
        public string[] TLD => new [] { ".fr" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.WesternEurope;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.AD,
            Alpha2Code.BE,
            Alpha2Code.DE,
            Alpha2Code.IT,
            Alpha2Code.LU,
            Alpha2Code.MC,
            Alpha2Code.ES,
            Alpha2Code.CH,
        };

        public ICurrency[] Currencies => new [] { new EurCurrency() };
        public string[] CallingCodes => new [] { "33" };
    }
}
