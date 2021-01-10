using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Ghana
    /// </summary>
    public class GhanaCountryInfo : ICountryInfo
    {
        public string CommonName => "Ghana";
        public string OfficialName => "Republic of Ghana";
        public Alpha2Code Alpha2Code => Alpha2Code.GH;
        public Alpha3Code Alpha3Code => Alpha3Code.GHA;
        public int NumericCode => 288;
        public string[] TLD => new [] { ".gh" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.WesternAfrica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.BF,
            Alpha2Code.CI,
            Alpha2Code.TG,
        };

        public ICurrency[] Currencies => new [] { new GhsCurrency() };
        public string[] CallingCodes => new [] { "233" };
    }
}
