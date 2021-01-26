using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Jersey
    /// </summary>
    public class JerseyCountryInfo : ICountryInfo
    {
        public string CommonName => "Jersey";
        public string OfficialName => "Bailiwick of Jersey";
        public Alpha2Code Alpha2Code => Alpha2Code.JE;
        public Alpha3Code Alpha3Code => Alpha3Code.JEY;
        public int NumericCode => 832;
        public string[] TLD => new [] { ".je" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.NorthernEurope;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new GbpCurrency() };
        public string[] CallingCodes => new [] { "44" };
    }
}
