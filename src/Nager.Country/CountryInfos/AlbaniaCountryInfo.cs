using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Albania
    /// </summary>
    public sealed class AlbaniaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Albania";

        /// <inheritdoc/>
        public string OfficialName => "Republic of Albania";

        /// <inheritdoc/>
        public string NativeName => "Shqipëria";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.AL;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.ALB;

        /// <inheritdoc/>
        public int NumericCode => 008;

        /// <inheritdoc/>
        public string[] TLD => [".al"];

        /// <inheritdoc/>
        public Region Region => Region.Europe;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.SoutheastEurope;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.ME,
            Alpha2Code.GR,
            Alpha2Code.MK,
            Alpha2Code.XK,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new AllCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["355"];
    }
}
