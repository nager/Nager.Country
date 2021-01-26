using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Nicaragua
    /// </summary>
    public class NicaraguaCountryInfo : ICountryInfo
    {
        public string CommonName => "Nicaragua";
        public string OfficialName => "Republic of Nicaragua";
        public Alpha2Code Alpha2Code => Alpha2Code.NI;
        public Alpha3Code Alpha3Code => Alpha3Code.NIC;
        public int NumericCode => 558;
        public string[] TLD => new [] { ".ni" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.CentralAmerica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.CR,
            Alpha2Code.HN,
        };

        public ICurrency[] Currencies => new [] { new NioCurrency() };
        public string[] CallingCodes => new [] { "505" };
    }
}
