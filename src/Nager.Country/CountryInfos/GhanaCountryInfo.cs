using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Ghana
    /// </summary>
    public sealed class GhanaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Ghana";

        /// <inheritdoc/>
        public string OfficialName => "Republic of Ghana";

        /// <inheritdoc/>
        public string NativeName => "Ghana";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.GH;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.GHA;

        /// <inheritdoc/>
        public int NumericCode => 288;

        /// <inheritdoc/>
        public string[] TLD => [".gh"];

        /// <inheritdoc/>
        public Region Region => Region.Africa;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.WesternAfrica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.BF,
            Alpha2Code.CI,
            Alpha2Code.TG,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [GhsCurrency.Instance];

        /// <inheritdoc/>
        public string[] CallingCodes => ["233"];
    }
}
