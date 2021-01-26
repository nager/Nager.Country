using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Pitcairn Islands
    /// </summary>
    public class PitcairnIslandsCountryInfo : ICountryInfo
    {
        public string CommonName => "Pitcairn Islands";
        public string OfficialName => "Pitcairn Group of Islands";
        public Alpha2Code Alpha2Code => Alpha2Code.PN;
        public Alpha3Code Alpha3Code => Alpha3Code.PCN;
        public int NumericCode => 612;
        public string[] TLD => new [] { ".pn" };

        public Region Region => Region.Oceania;
        public SubRegion SubRegion => SubRegion.Polynesia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new NzdCurrency() };
        public string[] CallingCodes => new [] { "64" };
    }
}
