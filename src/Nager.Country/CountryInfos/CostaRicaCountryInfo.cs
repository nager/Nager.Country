using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Costa Rica
    /// </summary>
    public class CostaRicaCountryInfo : ICountryInfo
    {
        public string CommonName => "Costa Rica";
        public string OfficialName => "Republic of Costa Rica";
        public Alpha2Code Alpha2Code => Alpha2Code.CR;
        public Alpha3Code Alpha3Code => Alpha3Code.CRI;
        public int NumericCode => 188;
        public string[] TLD => new [] { ".cr" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.CentralAmerica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.NI,
            Alpha2Code.PA,
        };

        public ICurrency[] Currencies => new [] { new CrcCurrency() };
        public string[] CallingCodes => new [] { "506" };
    }
}
