using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Libya
    /// </summary>
    public class LibyaCountryInfo : ICountryInfo
    {
        public string CommonName => "Libya";
        public string OfficialName => "State of Libya";
        public Alpha2Code Alpha2Code => Alpha2Code.LY;
        public Alpha3Code Alpha3Code => Alpha3Code.LBY;
        public int NumericCode => 434;
        public string[] TLD => new [] { ".ly" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.NorthernAfrica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.DZ,
            Alpha2Code.TD,
            Alpha2Code.EG,
            Alpha2Code.NE,
            Alpha2Code.SD,
            Alpha2Code.TN,
        };

        public ICurrency[] Currencies => new [] { new LydCurrency() };
        public string[] CallingCodes => new [] { "218" };
    }
}
