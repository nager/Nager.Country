using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Zambia
    /// </summary>
    public class ZambiaCountryInfo : ICountryInfo
    {
        public string CommonName => "Zambia";
        public string OfficialName => "Republic of Zambia";
        public Alpha2Code Alpha2Code => Alpha2Code.ZM;
        public Alpha3Code Alpha3Code => Alpha3Code.ZMB;
        public int NumericCode => 894;
        public string[] TLD => new [] { ".zm" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.EasternAfrica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.AO,
            Alpha2Code.BW,
            Alpha2Code.CD,
            Alpha2Code.MW,
            Alpha2Code.MZ,
            Alpha2Code.NA,
            Alpha2Code.TZ,
            Alpha2Code.ZW,
        };

        public ICurrency[] Currencies => new [] { new ZmwCurrency() };
        public string[] CallingCodes => new [] { "260" };
    }
}
