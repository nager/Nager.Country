using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// French Polynesia
    /// </summary>
    public class FrenchPolynesiaCountryInfo : ICountryInfo
    {
        public string CommonName => "French Polynesia";
        public string OfficialName => "French Polynesia";
        public Alpha2Code Alpha2Code => Alpha2Code.PF;
        public Alpha3Code Alpha3Code => Alpha3Code.PYF;
        public int NumericCode => 258;
        public string[] TLD => new [] { ".pf" };

        public Region Region => Region.Oceania;
        public SubRegion SubRegion => SubRegion.Polynesia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new XpfCurrency() };
        public string[] CallingCodes => new [] { "689" };
    }
}
