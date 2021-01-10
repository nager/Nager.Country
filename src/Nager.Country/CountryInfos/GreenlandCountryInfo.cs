using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Greenland
    /// </summary>
    public class GreenlandCountryInfo : ICountryInfo
    {
        public string CommonName => "Greenland";
        public string OfficialName => "Greenland";
        public Alpha2Code Alpha2Code => Alpha2Code.GL;
        public Alpha3Code Alpha3Code => Alpha3Code.GRL;
        public int NumericCode => 304;
        public string[] TLD => new [] { ".gl" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.NorthAmerica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new DkkCurrency() };
        public string[] CallingCodes => new [] { "299" };
    }
}
