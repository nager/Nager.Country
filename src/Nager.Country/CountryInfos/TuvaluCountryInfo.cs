using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Tuvalu
    /// </summary>
    public class TuvaluCountryInfo : ICountryInfo
    {
        public string CommonName => "Tuvalu";
        public string OfficialName => "Tuvalu";
        public Alpha2Code Alpha2Code => Alpha2Code.TV;
        public Alpha3Code Alpha3Code => Alpha3Code.TUV;
        public int NumericCode => 798;
        public string[] TLD => new [] { ".tv" };

        public Region Region => Region.Oceania;
        public SubRegion SubRegion => SubRegion.Polynesia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new AudCurrency() };
        public string[] CallingCodes => new [] { "688" };
    }
}
