using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// American Samoa
    /// </summary>
    public class AmericanSamoaCountryInfo : ICountryInfo
    {
        public string CommonName => "American Samoa";
        public string OfficialName => "American Samoa";
        public Alpha2Code Alpha2Code => Alpha2Code.AS;
        public Alpha3Code Alpha3Code => Alpha3Code.ASM;
        public int NumericCode => 016;
        public string[] TLD => new [] { ".as" };

        public Region Region => Region.Oceania;
        public SubRegion SubRegion => SubRegion.Polynesia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new UsdCurrency() };
        public string[] CallingCodes => new [] { "1684" };
    }
}
