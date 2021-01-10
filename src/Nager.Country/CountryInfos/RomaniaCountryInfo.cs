using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Romania
    /// </summary>
    public class RomaniaCountryInfo : ICountryInfo
    {
        public string CommonName => "Romania";
        public string OfficialName => "Romania";
        public Alpha2Code Alpha2Code => Alpha2Code.RO;
        public Alpha3Code Alpha3Code => Alpha3Code.ROU;
        public int NumericCode => 642;
        public string[] TLD => new [] { ".ro" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.EasternEurope;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.BG,
            Alpha2Code.HU,
            Alpha2Code.MD,
            Alpha2Code.RS,
            Alpha2Code.UA,
        };

        public ICurrency[] Currencies => new [] { new RonCurrency() };
        public string[] CallingCodes => new [] { "40" };
    }
}
