using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Honduras
    /// </summary>
    public class HondurasCountryInfo : ICountryInfo
    {
        public string CommonName => "Honduras";
        public string OfficialName => "Republic of Honduras";
        public Alpha2Code Alpha2Code => Alpha2Code.HN;
        public Alpha3Code Alpha3Code => Alpha3Code.HND;
        public int NumericCode => 340;
        public string[] TLD => new [] { ".hn" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.CentralAmerica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.GT,
            Alpha2Code.SV,
            Alpha2Code.NI,
        };

        public ICurrency[] Currencies => new [] { new HnlCurrency() };
        public string[] CallingCodes => new [] { "504" };
    }
}
