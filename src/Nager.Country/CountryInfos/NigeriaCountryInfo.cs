using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Nigeria
    /// </summary>
    public class NigeriaCountryInfo : ICountryInfo
    {
        public string CommonName => "Nigeria";
        public string OfficialName => "Federal Republic of Nigeria";
        public Alpha2Code Alpha2Code => Alpha2Code.NG;
        public Alpha3Code Alpha3Code => Alpha3Code.NGA;
        public int NumericCode => 566;
        public string[] TLD => new [] { ".ng" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.WesternAfrica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.BJ,
            Alpha2Code.CM,
            Alpha2Code.TD,
            Alpha2Code.NE,
        };

        public ICurrency[] Currencies => new [] { new NgnCurrency() };
        public string[] CallingCodes => new [] { "234" };
    }
}
