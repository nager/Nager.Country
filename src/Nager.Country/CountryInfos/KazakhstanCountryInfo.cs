using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Kazakhstan
    /// </summary>
    public class KazakhstanCountryInfo : ICountryInfo
    {
        public string CommonName => "Kazakhstan";
        public string OfficialName => "Republic of Kazakhstan";
        public Alpha2Code Alpha2Code => Alpha2Code.KZ;
        public Alpha3Code Alpha3Code => Alpha3Code.KAZ;
        public int NumericCode => 398;
        public string[] TLD => new [] { ".kz", ".қаз" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.CentralAsia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.CN,
            Alpha2Code.KG,
            Alpha2Code.RU,
            Alpha2Code.TM,
            Alpha2Code.UZ,
        };

        public ICurrency[] Currencies => new [] { new KztCurrency() };
        public string[] CallingCodes => new [] { "76", "77" };
    }
}
