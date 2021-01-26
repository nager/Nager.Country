using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// British Indian Ocean Territory
    /// </summary>
    public class BritishIndianOceanTerritoryCountryInfo : ICountryInfo
    {
        public string CommonName => "British Indian Ocean Territory";
        public string OfficialName => "British Indian Ocean Territory";
        public Alpha2Code Alpha2Code => Alpha2Code.IO;
        public Alpha3Code Alpha3Code => Alpha3Code.IOT;
        public int NumericCode => 086;
        public string[] TLD => new [] { ".io" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.EasternAfrica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new UsdCurrency() };
        public string[] CallingCodes => new [] { "246" };
    }
}
