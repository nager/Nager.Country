using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// French Guiana
    /// </summary>
    public class FrenchGuianaCountryInfo : ICountryInfo
    {
        public string CommonName => "French Guiana";
        public string OfficialName => "Guiana";
        public Alpha2Code Alpha2Code => Alpha2Code.GF;
        public Alpha3Code Alpha3Code => Alpha3Code.GUF;
        public int NumericCode => 254;
        public string[] TLD => new [] { ".gf" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.SouthAmerica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.BR,
            Alpha2Code.SR,
        };

        public ICurrency[] Currencies => new [] { new EurCurrency() };
        public string[] CallingCodes => new [] { "594" };
    }
}
