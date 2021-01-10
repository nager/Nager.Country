using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Portugal
    /// </summary>
    public class PortugalCountryInfo : ICountryInfo
    {
        public string CommonName => "Portugal";
        public string OfficialName => "Portuguese Republic";
        public Alpha2Code Alpha2Code => Alpha2Code.PT;
        public Alpha3Code Alpha3Code => Alpha3Code.PRT;
        public int NumericCode => 620;
        public string[] TLD => new [] { ".pt" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.SouthernEurope;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.ES,
        };

        public ICurrency[] Currencies => new [] { new EurCurrency() };
        public string[] CallingCodes => new [] { "351" };
    }
}
