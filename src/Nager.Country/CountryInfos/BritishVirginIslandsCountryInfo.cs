using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// British Virgin Islands
    /// </summary>
    public class BritishVirginIslandsCountryInfo : ICountryInfo
    {
        public string CommonName => "British Virgin Islands";
        public string OfficialName => "Virgin Islands";
        public Alpha2Code Alpha2Code => Alpha2Code.VG;
        public Alpha3Code Alpha3Code => Alpha3Code.VGB;
        public int NumericCode => 092;
        public string[] TLD => new [] { ".vg" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.Caribbean;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new UsdCurrency() };
        public string[] CallingCodes => new [] { "1284" };
    }
}
