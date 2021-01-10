using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Japan
    /// </summary>
    public class JapanCountryInfo : ICountryInfo
    {
        public string CommonName => "Japan";
        public string OfficialName => "Japan";
        public Alpha2Code Alpha2Code => Alpha2Code.JP;
        public Alpha3Code Alpha3Code => Alpha3Code.JPN;
        public int NumericCode => 392;
        public string[] TLD => new [] { ".jp", ".みんな" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.EasternAsia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new JpyCurrency() };
        public string[] CallingCodes => new [] { "81" };
    }
}
