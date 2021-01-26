using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Zimbabwe
    /// </summary>
    public class ZimbabweCountryInfo : ICountryInfo
    {
        public string CommonName => "Zimbabwe";
        public string OfficialName => "Republic of Zimbabwe";
        public Alpha2Code Alpha2Code => Alpha2Code.ZW;
        public Alpha3Code Alpha3Code => Alpha3Code.ZWE;
        public int NumericCode => 716;
        public string[] TLD => new [] { ".zw" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.EasternAfrica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.BW,
            Alpha2Code.MZ,
            Alpha2Code.ZA,
            Alpha2Code.ZM,
        };

        public ICurrency[] Currencies => new [] { new ZwlCurrency() };
        public string[] CallingCodes => new [] { "263" };
    }
}
