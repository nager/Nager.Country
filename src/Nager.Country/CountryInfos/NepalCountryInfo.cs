using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Nepal
    /// </summary>
    public class NepalCountryInfo : ICountryInfo
    {
        public string CommonName => "Nepal";
        public string OfficialName => "Federal Democratic Republic of Nepal";
        public Alpha2Code Alpha2Code => Alpha2Code.NP;
        public Alpha3Code Alpha3Code => Alpha3Code.NPL;
        public int NumericCode => 524;
        public string[] TLD => new [] { ".np" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.SouthernAsia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.CN,
            Alpha2Code.IN,
        };

        public ICurrency[] Currencies => new [] { new NprCurrency() };
        public string[] CallingCodes => new [] { "977" };
    }
}
