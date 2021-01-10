using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Hong Kong
    /// </summary>
    public class HongKongCountryInfo : ICountryInfo
    {
        public string CommonName => "Hong Kong";
        public string OfficialName => "Hong Kong Special Administrative Region of the People's Republic of China";
        public Alpha2Code Alpha2Code => Alpha2Code.HK;
        public Alpha3Code Alpha3Code => Alpha3Code.HKG;
        public int NumericCode => 344;
        public string[] TLD => new [] { ".hk", ".香港" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.EasternAsia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.CN,
        };

        public ICurrency[] Currencies => new [] { new HkdCurrency() };
        public string[] CallingCodes => new [] { "852" };
    }
}
