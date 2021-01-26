using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Tonga
    /// </summary>
    public class TongaCountryInfo : ICountryInfo
    {
        public string CommonName => "Tonga";
        public string OfficialName => "Kingdom of Tonga";
        public Alpha2Code Alpha2Code => Alpha2Code.TO;
        public Alpha3Code Alpha3Code => Alpha3Code.TON;
        public int NumericCode => 776;
        public string[] TLD => new [] { ".to" };

        public Region Region => Region.Oceania;
        public SubRegion SubRegion => SubRegion.Polynesia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new TopCurrency() };
        public string[] CallingCodes => new [] { "676" };
    }
}
