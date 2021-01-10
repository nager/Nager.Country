using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Ecuador
    /// </summary>
    public class EcuadorCountryInfo : ICountryInfo
    {
        public string CommonName => "Ecuador";
        public string OfficialName => "Republic of Ecuador";
        public Alpha2Code Alpha2Code => Alpha2Code.EC;
        public Alpha3Code Alpha3Code => Alpha3Code.ECU;
        public int NumericCode => 218;
        public string[] TLD => new [] { ".ec" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.SouthAmerica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.CO,
            Alpha2Code.PE,
        };

        public ICurrency[] Currencies => new [] { new UsdCurrency() };
        public string[] CallingCodes => new [] { "593" };
    }
}
