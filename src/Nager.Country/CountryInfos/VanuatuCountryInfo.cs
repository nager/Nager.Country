using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Vanuatu
    /// </summary>
    public class VanuatuCountryInfo : ICountryInfo
    {
        public string CommonName => "Vanuatu";
        public string OfficialName => "Republic of Vanuatu";
        public Alpha2Code Alpha2Code => Alpha2Code.VU;
        public Alpha3Code Alpha3Code => Alpha3Code.VUT;
        public int NumericCode => 548;
        public string[] TLD => new [] { ".vu" };

        public Region Region => Region.Oceania;
        public SubRegion SubRegion => SubRegion.Melanesia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new VuvCurrency() };
        public string[] CallingCodes => new [] { "678" };
    }
}
