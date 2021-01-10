using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Guatemala
    /// </summary>
    public class GuatemalaCountryInfo : ICountryInfo
    {
        public string CommonName => "Guatemala";
        public string OfficialName => "Republic of Guatemala";
        public Alpha2Code Alpha2Code => Alpha2Code.GT;
        public Alpha3Code Alpha3Code => Alpha3Code.GTM;
        public int NumericCode => 320;
        public string[] TLD => new [] { ".gt" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.CentralAmerica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.BZ,
            Alpha2Code.SV,
            Alpha2Code.HN,
            Alpha2Code.MX,
        };

        public ICurrency[] Currencies => new [] { new GtqCurrency() };
        public string[] CallingCodes => new [] { "502" };
    }
}
