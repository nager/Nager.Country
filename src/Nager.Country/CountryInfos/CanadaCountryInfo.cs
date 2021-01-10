using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Canada
    /// </summary>
    public class CanadaCountryInfo : ICountryInfo
    {
        public string CommonName => "Canada";
        public string OfficialName => "Canada";
        public Alpha2Code Alpha2Code => Alpha2Code.CA;
        public Alpha3Code Alpha3Code => Alpha3Code.CAN;
        public int NumericCode => 124;
        public string[] TLD => new [] { ".ca" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.NorthAmerica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.US,
        };

        public ICurrency[] Currencies => new [] { new CadCurrency() };
        public string[] CallingCodes => new [] { "1" };
    }
}
