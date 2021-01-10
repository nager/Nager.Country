using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Antarctica
    /// </summary>
    public class AntarcticaCountryInfo : ICountryInfo
    {
        public string CommonName => "Antarctica";
        public string OfficialName => "Antarctica";
        public Alpha2Code Alpha2Code => Alpha2Code.AQ;
        public Alpha3Code Alpha3Code => Alpha3Code.ATA;
        public int NumericCode => 010;
        public string[] TLD => new [] { ".aq" };

        public Region Region => Region.Antarctic;
        public SubRegion SubRegion => SubRegion.None;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new ICurrency[0];
        public string[] CallingCodes => new string[0];
    }
}
