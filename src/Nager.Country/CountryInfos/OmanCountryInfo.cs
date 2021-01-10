using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Oman
    /// </summary>
    public class OmanCountryInfo : ICountryInfo
    {
        public string CommonName => "Oman";
        public string OfficialName => "Sultanate of Oman";
        public Alpha2Code Alpha2Code => Alpha2Code.OM;
        public Alpha3Code Alpha3Code => Alpha3Code.OMN;
        public int NumericCode => 512;
        public string[] TLD => new [] { ".om" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.WesternAsia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.SA,
            Alpha2Code.AE,
            Alpha2Code.YE,
        };

        public ICurrency[] Currencies => new [] { new OmrCurrency() };
        public string[] CallingCodes => new [] { "968" };
    }
}
