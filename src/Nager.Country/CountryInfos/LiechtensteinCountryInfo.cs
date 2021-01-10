using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Liechtenstein
    /// </summary>
    public class LiechtensteinCountryInfo : ICountryInfo
    {
        public string CommonName => "Liechtenstein";
        public string OfficialName => "Principality of Liechtenstein";
        public Alpha2Code Alpha2Code => Alpha2Code.LI;
        public Alpha3Code Alpha3Code => Alpha3Code.LIE;
        public int NumericCode => 438;
        public string[] TLD => new [] { ".li" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.WesternEurope;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.AT,
            Alpha2Code.CH,
        };

        public ICurrency[] Currencies => new [] { new ChfCurrency() };
        public string[] CallingCodes => new [] { "423" };
    }
}
