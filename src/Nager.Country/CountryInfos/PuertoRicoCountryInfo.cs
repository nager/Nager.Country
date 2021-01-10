using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Puerto Rico
    /// </summary>
    public class PuertoRicoCountryInfo : ICountryInfo
    {
        public string CommonName => "Puerto Rico";
        public string OfficialName => "Commonwealth of Puerto Rico";
        public Alpha2Code Alpha2Code => Alpha2Code.PR;
        public Alpha3Code Alpha3Code => Alpha3Code.PRI;
        public int NumericCode => 630;
        public string[] TLD => new [] { ".pr" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.Caribbean;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new UsdCurrency() };
        public string[] CallingCodes => new [] { "1787", "1939" };
    }
}
