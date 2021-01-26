using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Rwanda
    /// </summary>
    public class RwandaCountryInfo : ICountryInfo
    {
        public string CommonName => "Rwanda";
        public string OfficialName => "Republic of Rwanda";
        public Alpha2Code Alpha2Code => Alpha2Code.RW;
        public Alpha3Code Alpha3Code => Alpha3Code.RWA;
        public int NumericCode => 646;
        public string[] TLD => new [] { ".rw" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.EasternAfrica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.BI,
            Alpha2Code.CD,
            Alpha2Code.TZ,
            Alpha2Code.UG,
        };

        public ICurrency[] Currencies => new [] { new RwfCurrency() };
        public string[] CallingCodes => new [] { "250" };
    }
}
