using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Equatorial Guinea
    /// </summary>
    public class EquatorialGuineaCountryInfo : ICountryInfo
    {
        public string CommonName => "Equatorial Guinea";
        public string OfficialName => "Republic of Equatorial Guinea";
        public Alpha2Code Alpha2Code => Alpha2Code.GQ;
        public Alpha3Code Alpha3Code => Alpha3Code.GNQ;
        public int NumericCode => 226;
        public string[] TLD => new [] { ".gq" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.MiddleAfrica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.CM,
            Alpha2Code.GA,
        };

        public ICurrency[] Currencies => new [] { new XafCurrency() };
        public string[] CallingCodes => new [] { "240" };
    }
}
