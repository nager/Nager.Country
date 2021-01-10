using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Guyana
    /// </summary>
    public class GuyanaCountryInfo : ICountryInfo
    {
        public string CommonName => "Guyana";
        public string OfficialName => "Co-operative Republic of Guyana";
        public Alpha2Code Alpha2Code => Alpha2Code.GY;
        public Alpha3Code Alpha3Code => Alpha3Code.GUY;
        public int NumericCode => 328;
        public string[] TLD => new [] { ".gy" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.SouthAmerica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.BR,
            Alpha2Code.SR,
            Alpha2Code.VE,
        };

        public ICurrency[] Currencies => new [] { new GydCurrency() };
        public string[] CallingCodes => new [] { "592" };
    }
}
