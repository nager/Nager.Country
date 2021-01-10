using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Andorra
    /// </summary>
    public class AndorraCountryInfo : ICountryInfo
    {
        public string CommonName => "Andorra";
        public string OfficialName => "Principality of Andorra";
        public Alpha2Code Alpha2Code => Alpha2Code.AD;
        public Alpha3Code Alpha3Code => Alpha3Code.AND;
        public int NumericCode => 020;
        public string[] TLD => new [] { ".ad" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.SouthernEurope;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.FR,
            Alpha2Code.ES,
        };

        public ICurrency[] Currencies => new [] { new EurCurrency() };
        public string[] CallingCodes => new [] { "376" };
    }
}
