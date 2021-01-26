using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Sri Lanka
    /// </summary>
    public class SriLankaCountryInfo : ICountryInfo
    {
        public string CommonName => "Sri Lanka";
        public string OfficialName => "Democratic Socialist Republic of Sri Lanka";
        public Alpha2Code Alpha2Code => Alpha2Code.LK;
        public Alpha3Code Alpha3Code => Alpha3Code.LKA;
        public int NumericCode => 144;
        public string[] TLD => new [] { ".lk", ".இலங்கை", ".ලංකා" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.SouthernAsia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.IN,
        };

        public ICurrency[] Currencies => new [] { new LkrCurrency() };
        public string[] CallingCodes => new [] { "94" };
    }
}
