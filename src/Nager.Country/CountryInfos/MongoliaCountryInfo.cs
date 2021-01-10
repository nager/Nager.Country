using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Mongolia
    /// </summary>
    public class MongoliaCountryInfo : ICountryInfo
    {
        public string CommonName => "Mongolia";
        public string OfficialName => "Mongolia";
        public Alpha2Code Alpha2Code => Alpha2Code.MN;
        public Alpha3Code Alpha3Code => Alpha3Code.MNG;
        public int NumericCode => 496;
        public string[] TLD => new [] { ".mn" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.EasternAsia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.CN,
            Alpha2Code.RU,
        };

        public ICurrency[] Currencies => new [] { new MntCurrency() };
        public string[] CallingCodes => new [] { "976" };
    }
}
