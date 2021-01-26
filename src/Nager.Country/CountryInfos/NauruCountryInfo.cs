using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Nauru
    /// </summary>
    public class NauruCountryInfo : ICountryInfo
    {
        public string CommonName => "Nauru";
        public string OfficialName => "Republic of Nauru";
        public Alpha2Code Alpha2Code => Alpha2Code.NR;
        public Alpha3Code Alpha3Code => Alpha3Code.NRU;
        public int NumericCode => 520;
        public string[] TLD => new [] { ".nr" };

        public Region Region => Region.Oceania;
        public SubRegion SubRegion => SubRegion.Micronesia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new AudCurrency() };
        public string[] CallingCodes => new [] { "674" };
    }
}
