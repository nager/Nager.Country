using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Malta
    /// </summary>
    public class MaltaCountryInfo : ICountryInfo
    {
        public string CommonName => "Malta";
        public string OfficialName => "Republic of Malta";
        public Alpha2Code Alpha2Code => Alpha2Code.MT;
        public Alpha3Code Alpha3Code => Alpha3Code.MLT;
        public int NumericCode => 470;
        public string[] TLD => new [] { ".mt" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.SouthernEurope;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new EurCurrency() };
        public string[] CallingCodes => new [] { "356" };
    }
}
