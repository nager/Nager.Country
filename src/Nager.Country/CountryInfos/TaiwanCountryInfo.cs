using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Taiwan
    /// </summary>
    public class TaiwanCountryInfo : ICountryInfo
    {
        public string CommonName => "Taiwan";
        public string OfficialName => "Republic of China";
        public Alpha2Code Alpha2Code => Alpha2Code.TW;
        public Alpha3Code Alpha3Code => Alpha3Code.TWN;
        public int NumericCode => 158;
        public string[] TLD => new [] { ".tw", ".台湾", ".台灣" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.EasternAsia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new TwdCurrency() };
        public string[] CallingCodes => new [] { "886" };
    }
}
