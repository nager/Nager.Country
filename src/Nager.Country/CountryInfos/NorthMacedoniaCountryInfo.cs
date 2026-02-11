using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// North Macedonia
    /// </summary>
    public sealed class NorthMacedoniaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "North Macedonia";

        /// <inheritdoc/>
        public string OfficialName => "Republic of North Macedonia";

        /// <inheritdoc/>
        public string NativeName => "Северна Македонија";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.MK;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.MKD;

        /// <inheritdoc/>
        public int NumericCode => 807;

        /// <inheritdoc/>
        public string[] TLD => [".mk"];

        /// <inheritdoc/>
        public Region Region => Region.Europe;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.SoutheastEurope;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.AL,
            Alpha2Code.BG,
            Alpha2Code.GR,
            Alpha2Code.RS,
            Alpha2Code.XK,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new MkdCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["389"];
    }
}
