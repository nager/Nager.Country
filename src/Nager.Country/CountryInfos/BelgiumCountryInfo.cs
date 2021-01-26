using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Belgium
    /// </summary>
    public class BelgiumCountryInfo : ICountryInfo
    {
        public string CommonName => "Belgium";
        public string OfficialName => "Kingdom of Belgium";
        public Alpha2Code Alpha2Code => Alpha2Code.BE;
        public Alpha3Code Alpha3Code => Alpha3Code.BEL;
        public int NumericCode => 056;
        public string[] TLD => new [] { ".be" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.WesternEurope;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.FR,
            Alpha2Code.DE,
            Alpha2Code.LU,
            Alpha2Code.NL,
        };

        public ICurrency[] Currencies => new [] { new EurCurrency() };
        public string[] CallingCodes => new [] { "32" };
    }
}
