using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Ethiopia
    /// </summary>
    public class EthiopiaCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Ethiopia";
        ///<inheritdoc/>
        public string OfficialName => "Federal Democratic Republic of Ethiopia";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.ET;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.ETH;
        ///<inheritdoc/>
        public int NumericCode => 231;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".et" };

        ///<inheritdoc/>
        public Region Region => Region.Africa;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.EasternAfrica;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.DJ,
            Alpha2Code.ER,
            Alpha2Code.KE,
            Alpha2Code.SO,
            Alpha2Code.SS,
            Alpha2Code.SD,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new EtbCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "251" };
    }
}
