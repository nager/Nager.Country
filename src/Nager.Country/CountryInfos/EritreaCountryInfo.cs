using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Eritrea
    /// </summary>
    public sealed class EritreaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Eritrea";

        /// <inheritdoc/>
        public string OfficialName => "State of Eritrea";

        /// <inheritdoc/>
        public string NativeName => "ኤርትራ";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.ER;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.ERI;

        /// <inheritdoc/>
        public int NumericCode => 232;

        /// <inheritdoc/>
        public string[] TLD => [".er"];

        /// <inheritdoc/>
        public Region Region => Region.Africa;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.EasternAfrica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.DJ,
            Alpha2Code.ET,
            Alpha2Code.SD,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [ErnCurrency.Instance];

        /// <inheritdoc/>
        public string[] CallingCodes => ["291"];
    }
}
