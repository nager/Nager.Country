using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Algeria
    /// </summary>
    public sealed class AlgeriaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Algeria";

        /// <inheritdoc/>
        public string OfficialName => "People's Democratic Republic of Algeria";

        /// <inheritdoc/>
        public string NativeName => "الجزائر";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.DZ;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.DZA;

        /// <inheritdoc/>
        public int NumericCode => 012;

        /// <inheritdoc/>
        public string[] TLD => [".dz", "الجزائر."];

        /// <inheritdoc/>
        public Region Region => Region.Africa;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.NorthernAfrica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.TN,
            Alpha2Code.LY,
            Alpha2Code.NE,
            Alpha2Code.EH,
            Alpha2Code.MR,
            Alpha2Code.ML,
            Alpha2Code.MA,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [DzdCurrency.Instance];

        /// <inheritdoc/>
        public string[] CallingCodes => ["213"];
    }
}
