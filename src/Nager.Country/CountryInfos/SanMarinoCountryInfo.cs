using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// San Marino
    /// </summary>
    public class SanMarinoCountryInfo : ICountryInfo
    {
        public string CommonName => "San Marino";
        public string OfficialName => "Most Serene Republic of San Marino";
        public Alpha2Code Alpha2Code => Alpha2Code.SM;
        public Alpha3Code Alpha3Code => Alpha3Code.SMR;
        public int NumericCode => 674;
        public string[] TLD => new [] { ".sm" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.SouthernEurope;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.IT,
        };

        public ICurrency[] Currencies => new [] { new EurCurrency() };
        public string[] CallingCodes => new [] { "378" };
    }
}
