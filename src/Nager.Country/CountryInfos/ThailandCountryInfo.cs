using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Thailand
    /// </summary>
    public class ThailandCountryInfo : ICountryInfo
    {
        public string CommonName => "Thailand";
        public string OfficialName => "Kingdom of Thailand";
        public Alpha2Code Alpha2Code => Alpha2Code.TH;
        public Alpha3Code Alpha3Code => Alpha3Code.THA;
        public int NumericCode => 764;
        public string[] TLD => new [] { ".th", ".ไทย" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.SouthEasternAsia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.MM,
            Alpha2Code.KH,
            Alpha2Code.LA,
            Alpha2Code.MY,
        };

        public ICurrency[] Currencies => new [] { new ThbCurrency() };
        public string[] CallingCodes => new [] { "66" };
    }
}
