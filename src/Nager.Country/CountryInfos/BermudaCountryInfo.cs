using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Bermuda
    /// </summary>
    public class BermudaCountryInfo : ICountryInfo
    {
        public string CommonName => "Bermuda";
        public string OfficialName => "Bermuda";
        public Alpha2Code Alpha2Code => Alpha2Code.BM;
        public Alpha3Code Alpha3Code => Alpha3Code.BMU;
        public int NumericCode => 060;
        public string[] TLD => new [] { ".bm" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.NorthAmerica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new BmdCurrency() };
        public string[] CallingCodes => new [] { "1441" };
    }
}
