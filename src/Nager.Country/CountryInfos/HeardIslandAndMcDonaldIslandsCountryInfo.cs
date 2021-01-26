using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Heard Island and McDonald Islands
    /// </summary>
    public class HeardIslandAndMcDonaldIslandsCountryInfo : ICountryInfo
    {
        public string CommonName => "Heard Island and McDonald Islands";
        public string OfficialName => "Heard Island and McDonald Islands";
        public Alpha2Code Alpha2Code => Alpha2Code.HM;
        public Alpha3Code Alpha3Code => Alpha3Code.HMD;
        public int NumericCode => 334;
        public string[] TLD => new [] { ".hm", ".aq" };

        public Region Region => Region.Antarctic;
        public SubRegion SubRegion => SubRegion.None;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new AudCurrency() };
        public string[] CallingCodes => new string[0];
    }
}
