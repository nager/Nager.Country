using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Saudi Arabia
    /// </summary>
    public sealed class SaudiArabiaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Saudi Arabia";

        /// <inheritdoc/>
        public string OfficialName => "Kingdom of Saudi Arabia";

        /// <inheritdoc/>
        public string NativeName => "العربية السعودية";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.SA;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.SAU;

        /// <inheritdoc/>
        public int NumericCode => 682;

        /// <inheritdoc/>
        public string[] TLD =>
        [
            ".sa",
            ".السعودية",
        ];

        /// <inheritdoc/>
        public Region Region => Region.Asia;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.WesternAsia;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.IQ,
            Alpha2Code.JO,
            Alpha2Code.KW,
            Alpha2Code.OM,
            Alpha2Code.QA,
            Alpha2Code.AE,
            Alpha2Code.YE,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new SarCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["966"];
    }
}
