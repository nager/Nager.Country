using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Taiwan
    /// </summary>
    public sealed class TaiwanCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Taiwan";

        /// <inheritdoc/>
        public string OfficialName => "Republic of China";

        /// <inheritdoc/>
        public string NativeName => "臺灣";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.TW;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.TWN;

        /// <inheritdoc/>
        public int NumericCode => 158;

        /// <inheritdoc/>
        public string[] TLD =>
        [
            ".tw",
            ".台湾",
            ".台灣",
        ];

        /// <inheritdoc/>
        public Region Region => Region.Asia;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.EasternAsia;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => [];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new TwdCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["886"];
    }
}
