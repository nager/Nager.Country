using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Bangladesh
    /// </summary>
    public class BangladeshCountryInfo : ICountryInfo
    {
        public string CommonName => "Bangladesh";
        public string OfficialName => "People's Republic of Bangladesh";
        public Alpha2Code Alpha2Code => Alpha2Code.BD;
        public Alpha3Code Alpha3Code => Alpha3Code.BGD;
        public int NumericCode => 050;
        public string[] TLD => new [] { ".bd" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.SouthernAsia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.MM,
            Alpha2Code.IN,
        };

        public ICurrency[] Currencies => new [] { new BdtCurrency() };
        public string[] CallingCodes => new [] { "880" };
    }
}
