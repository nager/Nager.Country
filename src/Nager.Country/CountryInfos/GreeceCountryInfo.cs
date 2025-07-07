using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Greece
    /// </summary>
    public sealed class GreeceCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Greece";

        /// <inheritdoc/>
        public string OfficialName => "Hellenic Republic";

        /// <inheritdoc/>
        public string NativeName => "Ελλάδα";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.GR;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.GRC;

        /// <inheritdoc/>
        public int NumericCode => 300;

        /// <inheritdoc/>
        public string[] TLD => [".gr"];

        /// <inheritdoc/>
        public Region Region => Region.Europe;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthernEurope;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.AL,
            Alpha2Code.BG,
            Alpha2Code.TR,
            Alpha2Code.MK,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new EurCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["30"];
    }
}
