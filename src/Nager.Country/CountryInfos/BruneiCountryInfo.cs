using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Brunei
    /// </summary>
    public class BruneiCountryInfo : ICountryInfo
    {
        public string CommonName => "Brunei";
        public string OfficialName => "Nation of Brunei, Abode of Peace";
        public Alpha2Code Alpha2Code => Alpha2Code.BN;
        public Alpha3Code Alpha3Code => Alpha3Code.BRN;
        public int NumericCode => 096;
        public string[] TLD => new [] { ".bn" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.SouthEasternAsia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.MY,
        };

        public ICurrency[] Currencies => new [] { new BndCurrency() };
        public string[] CallingCodes => new [] { "673" };
    }
}
