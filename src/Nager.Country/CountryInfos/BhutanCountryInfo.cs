using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Bhutan
    /// </summary>
    public sealed class BhutanCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Bhutan";

        /// <inheritdoc/>
        public string OfficialName => "Kingdom of Bhutan";

        /// <inheritdoc/>
        public string NativeName => "ʼbrug-yul";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.BT;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.BTN;

        /// <inheritdoc/>
        public int NumericCode => 064;

        /// <inheritdoc/>
        public string[] TLD => [".bt"];

        /// <inheritdoc/>
        public Region Region => Region.Asia;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthernAsia;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.CN,
            Alpha2Code.IN,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies =>
        [
            BtnCurrency.Instance,
            InrCurrency.Instance,
        ];

        /// <inheritdoc/>
        public string[] CallingCodes => ["975"];
    }
}
