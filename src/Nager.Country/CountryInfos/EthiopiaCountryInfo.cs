using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Ethiopia
    /// </summary>
    public class EthiopiaCountryInfo : ICountryInfo
    {
        public string CommonName => "Ethiopia";
        public string OfficialName => "Federal Democratic Republic of Ethiopia";
        public Alpha2Code Alpha2Code => Alpha2Code.ET;
        public Alpha3Code Alpha3Code => Alpha3Code.ETH;
        public int NumericCode => 231;
        public string[] TLD => new [] { ".et" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.EasternAfrica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.DJ,
            Alpha2Code.ER,
            Alpha2Code.KE,
            Alpha2Code.SO,
            Alpha2Code.SS,
            Alpha2Code.SD,
        };

        public ICurrency[] Currencies => new [] { new EtbCurrency() };
        public string[] CallingCodes => new [] { "251" };
    }
}
