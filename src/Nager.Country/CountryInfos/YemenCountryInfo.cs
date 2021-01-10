using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Yemen
    /// </summary>
    public class YemenCountryInfo : ICountryInfo
    {
        public string CommonName => "Yemen";
        public string OfficialName => "Republic of Yemen";
        public Alpha2Code Alpha2Code => Alpha2Code.YE;
        public Alpha3Code Alpha3Code => Alpha3Code.YEM;
        public int NumericCode => 887;
        public string[] TLD => new [] { ".ye" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.WesternAsia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.OM,
            Alpha2Code.SA,
        };

        public ICurrency[] Currencies => new [] { new YerCurrency() };
        public string[] CallingCodes => new [] { "967" };
    }
}
