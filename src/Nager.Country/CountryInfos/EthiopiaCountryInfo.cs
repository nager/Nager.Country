using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Ethiopia
    /// </summary>
    public sealed class EthiopiaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Ethiopia";

        /// <inheritdoc/>
        public string OfficialName => "Federal Democratic Republic of Ethiopia";

        /// <inheritdoc/>
        public string NativeName => "ኢትዮጵያ";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.ET;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.ETH;

        /// <inheritdoc/>
        public int NumericCode => 231;

        /// <inheritdoc/>
        public string[] TLD => [".et"];

        /// <inheritdoc/>
        public Region Region => Region.Africa;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.EasternAfrica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.DJ,
            Alpha2Code.ER,
            Alpha2Code.KE,
            Alpha2Code.SO,
            Alpha2Code.SS,
            Alpha2Code.SD,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [EtbCurrency.Instance];

        /// <inheritdoc/>
        public string[] CallingCodes => ["251"];
    }
}
