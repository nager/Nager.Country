using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Solomon Islands
    /// </summary>
    public class SolomonIslandsCountryInfo : ICountryInfo
    {
        public string CommonName => "Solomon Islands";
        public string OfficialName => "Solomon Islands";
        public Alpha2Code Alpha2Code => Alpha2Code.SB;
        public Alpha3Code Alpha3Code => Alpha3Code.SLB;
        public int NumericCode => 090;
        public string[] TLD => new [] { ".sb" };

        public Region Region => Region.Oceania;
        public SubRegion SubRegion => SubRegion.Melanesia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new SbdCurrency() };
        public string[] CallingCodes => new [] { "677" };
    }
}
