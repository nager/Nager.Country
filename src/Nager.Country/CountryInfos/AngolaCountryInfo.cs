using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Angola
    /// </summary>
    public class AngolaCountryInfo : ICountryInfo
    {
        public string CommonName => "Angola";
        public string OfficialName => "Republic of Angola";
        public Alpha2Code Alpha2Code => Alpha2Code.AO;
        public Alpha3Code Alpha3Code => Alpha3Code.AGO;
        public int NumericCode => 024;
        public string[] TLD => new [] { ".ao" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.MiddleAfrica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.CG,
            Alpha2Code.CD,
            Alpha2Code.ZM,
            Alpha2Code.NA,
        };

        public ICurrency[] Currencies => new [] { new AoaCurrency() };
        public string[] CallingCodes => new [] { "244" };
    }
}
