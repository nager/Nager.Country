using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// United Kingdom
    /// </summary>
    public class UnitedKingdomCountryInfo : ICountryInfo
    {
        public string CommonName => "United Kingdom";
        public string OfficialName => "United Kingdom of Great Britain and Northern Ireland";
        public Alpha2Code Alpha2Code => Alpha2Code.GB;
        public Alpha3Code Alpha3Code => Alpha3Code.GBR;
        public int NumericCode => 826;
        public string[] TLD => new [] { ".uk" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.NorthernEurope;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.IE,
        };

        public ICurrency[] Currencies => new [] { new GbpCurrency() };
        public string[] CallingCodes => new [] { "44" };
    }
}
