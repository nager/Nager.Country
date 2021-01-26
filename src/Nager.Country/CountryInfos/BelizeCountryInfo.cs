using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Belize
    /// </summary>
    public class BelizeCountryInfo : ICountryInfo
    {
        public string CommonName => "Belize";
        public string OfficialName => "Belize";
        public Alpha2Code Alpha2Code => Alpha2Code.BZ;
        public Alpha3Code Alpha3Code => Alpha3Code.BLZ;
        public int NumericCode => 084;
        public string[] TLD => new [] { ".bz" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.CentralAmerica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.GT,
            Alpha2Code.MX,
        };

        public ICurrency[] Currencies => new [] { new BzdCurrency() };
        public string[] CallingCodes => new [] { "501" };
    }
}
