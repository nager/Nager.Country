using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Czech Republic
    /// </summary>
    public class CzechRepublicCountryInfo : ICountryInfo
    {
        public string CommonName => "Czechia";
        public string OfficialName => "Czech Republic";
        public Alpha2Code Alpha2Code => Alpha2Code.CZ;
        public Alpha3Code Alpha3Code => Alpha3Code.CZE;
        public int NumericCode => 203;
        public string[] TLD => new [] { ".cz" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.EasternEurope;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.AT,
            Alpha2Code.DE,
            Alpha2Code.PL,
            Alpha2Code.SK,
        };

        public ICurrency[] Currencies => new [] { new CzkCurrency() };
        public string[] CallingCodes => new [] { "420" };
    }
}
