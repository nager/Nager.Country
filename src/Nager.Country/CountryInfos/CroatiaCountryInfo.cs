using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Croatia
    /// </summary>
    public class CroatiaCountryInfo : ICountryInfo
    {
        public string CommonName => "Croatia";
        public string OfficialName => "Republic of Croatia";
        public Alpha2Code Alpha2Code => Alpha2Code.HR;
        public Alpha3Code Alpha3Code => Alpha3Code.HRV;
        public int NumericCode => 191;
        public string[] TLD => new [] { ".hr" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.SouthernEurope;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.BA,
            Alpha2Code.HU,
            Alpha2Code.ME,
            Alpha2Code.RS,
            Alpha2Code.SI,
        };

        public ICurrency[] Currencies => new [] { new HrkCurrency() };
        public string[] CallingCodes => new [] { "385" };
    }
}
