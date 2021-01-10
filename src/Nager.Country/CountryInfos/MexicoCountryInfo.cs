using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Mexico
    /// </summary>
    public class MexicoCountryInfo : ICountryInfo
    {
        public string CommonName => "Mexico";
        public string OfficialName => "United Mexican States";
        public Alpha2Code Alpha2Code => Alpha2Code.MX;
        public Alpha3Code Alpha3Code => Alpha3Code.MEX;
        public int NumericCode => 484;
        public string[] TLD => new [] { ".mx" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.NorthAmerica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.BZ,
            Alpha2Code.GT,
            Alpha2Code.US,
        };

        public ICurrency[] Currencies => new [] { new MxnCurrency() };
        public string[] CallingCodes => new [] { "52" };
    }
}
