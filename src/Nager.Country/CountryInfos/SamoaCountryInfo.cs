using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Samoa
    /// </summary>
    public class SamoaCountryInfo : ICountryInfo
    {
        public string CommonName => "Samoa";
        public string OfficialName => "Independent State of Samoa";
        public Alpha2Code Alpha2Code => Alpha2Code.WS;
        public Alpha3Code Alpha3Code => Alpha3Code.WSM;
        public int NumericCode => 882;
        public string[] TLD => new [] { ".ws" };

        public Region Region => Region.Oceania;
        public SubRegion SubRegion => SubRegion.Polynesia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new WstCurrency() };
        public string[] CallingCodes => new [] { "685" };
    }
}
