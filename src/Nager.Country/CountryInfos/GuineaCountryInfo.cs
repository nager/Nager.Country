using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Guinea
    /// </summary>
    public class GuineaCountryInfo : ICountryInfo
    {
        public string CommonName => "Guinea";
        public string OfficialName => "Republic of Guinea";
        public Alpha2Code Alpha2Code => Alpha2Code.GN;
        public Alpha3Code Alpha3Code => Alpha3Code.GIN;
        public int NumericCode => 324;
        public string[] TLD => new [] { ".gn" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.WesternAfrica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.CI,
            Alpha2Code.GW,
            Alpha2Code.LR,
            Alpha2Code.ML,
            Alpha2Code.SN,
            Alpha2Code.SL,
        };

        public ICurrency[] Currencies => new [] { new GnfCurrency() };
        public string[] CallingCodes => new [] { "224" };
    }
}
