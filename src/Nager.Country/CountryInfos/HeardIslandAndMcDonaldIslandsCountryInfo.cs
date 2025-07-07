using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Heard Island and McDonald Islands
    /// </summary>
    public sealed class HeardIslandAndMcDonaldIslandsCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Heard Island and McDonald Islands";

        /// <inheritdoc/>
        public string OfficialName => "Heard Island and McDonald Islands";

        /// <inheritdoc/>
        public string NativeName => "Heard Island and McDonald Islands";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.HM;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.HMD;

        /// <inheritdoc/>
        public int NumericCode => 334;

        /// <inheritdoc/>
        public string[] TLD => 
        [
            ".hm",
            ".aq",
        ];

        /// <inheritdoc/>
        public Region Region => Region.Antarctic;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.None;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => [];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new AudCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => [];
    }
}
