using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Malaysia
    /// </summary>
    public class MalaysiaCountryInfo : ICountryInfo
    {
        public string CommonName => "Malaysia";
        public string OfficialName => "Malaysia";
        public Alpha2Code Alpha2Code => Alpha2Code.MY;
        public Alpha3Code Alpha3Code => Alpha3Code.MYS;
        public int NumericCode => 458;
        public string[] TLD => new [] { ".my" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.SouthEasternAsia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.BN,
            Alpha2Code.ID,
            Alpha2Code.TH,
        };

        public ICurrency[] Currencies => new [] { new MyrCurrency() };
        public string[] CallingCodes => new [] { "60" };
    }
}
