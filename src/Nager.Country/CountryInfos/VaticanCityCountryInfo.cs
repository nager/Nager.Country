using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Vatican City
    /// </summary>
    public class VaticanCityCountryInfo : ICountryInfo
    {
        public string CommonName => "Vatican City";
        public string OfficialName => "Vatican City State";
        public Alpha2Code Alpha2Code => Alpha2Code.VA;
        public Alpha3Code Alpha3Code => Alpha3Code.VAT;
        public int NumericCode => 336;
        public string[] TLD => new [] { ".va" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.SouthernEurope;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.IT,
        };

        public ICurrency[] Currencies => new [] { new EurCurrency() };
        public string[] CallingCodes => new [] { "3906698", "379" };
    }
}
