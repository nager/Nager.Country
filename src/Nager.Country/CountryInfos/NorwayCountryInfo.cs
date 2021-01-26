using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Norway
    /// </summary>
    public class NorwayCountryInfo : ICountryInfo
    {
        public string CommonName => "Norway";
        public string OfficialName => "Kingdom of Norway";
        public Alpha2Code Alpha2Code => Alpha2Code.NO;
        public Alpha3Code Alpha3Code => Alpha3Code.NOR;
        public int NumericCode => 578;
        public string[] TLD => new [] { ".no" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.NorthernEurope;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.FI,
            Alpha2Code.SE,
            Alpha2Code.RU,
        };

        public ICurrency[] Currencies => new [] { new NokCurrency() };
        public string[] CallingCodes => new [] { "47" };
    }
}
