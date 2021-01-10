using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Micronesia
    /// </summary>
    public class MicronesiaCountryInfo : ICountryInfo
    {
        public string CommonName => "Micronesia";
        public string OfficialName => "Federated States of Micronesia";
        public Alpha2Code Alpha2Code => Alpha2Code.FM;
        public Alpha3Code Alpha3Code => Alpha3Code.FSM;
        public int NumericCode => 583;
        public string[] TLD => new [] { ".fm" };

        public Region Region => Region.Oceania;
        public SubRegion SubRegion => SubRegion.Micronesia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new UsdCurrency() };
        public string[] CallingCodes => new [] { "691" };
    }
}
