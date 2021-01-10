using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Lesotho
    /// </summary>
    public class LesothoCountryInfo : ICountryInfo
    {
        public string CommonName => "Lesotho";
        public string OfficialName => "Kingdom of Lesotho";
        public Alpha2Code Alpha2Code => Alpha2Code.LS;
        public Alpha3Code Alpha3Code => Alpha3Code.LSO;
        public int NumericCode => 426;
        public string[] TLD => new [] { ".ls" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.SouthernAfrica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.ZA,
        };

        public ICurrency[] Currencies => new ICurrency[] { new LslCurrency(), new ZarCurrency() };
        public string[] CallingCodes => new [] { "266" };
    }
}
