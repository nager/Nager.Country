using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Germany
    /// </summary>
    public class GermanyCountryInfo : ICountryInfo
    {
        public string CommonName => "Germany";
        public string OfficialName => "Federal Republic of Germany";
        public Alpha2Code Alpha2Code => Alpha2Code.DE;
        public Alpha3Code Alpha3Code => Alpha3Code.DEU;
        public int NumericCode => 276;
        public string[] TLD => new [] { ".de" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.WesternEurope;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.AT,
            Alpha2Code.BE,
            Alpha2Code.CZ,
            Alpha2Code.DK,
            Alpha2Code.FR,
            Alpha2Code.LU,
            Alpha2Code.NL,
            Alpha2Code.PL,
            Alpha2Code.CH,
        };

        public ICurrency[] Currencies => new [] { new EurCurrency() };
        public string[] CallingCodes => new [] { "49" };
    }
}
