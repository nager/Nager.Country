using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Argentina
    /// </summary>
    public sealed class ArgentinaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Argentina";

        /// <inheritdoc/>
        public string OfficialName => "Argentine Republic";

        /// <inheritdoc/>
        public string NativeName => "Argentina";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.AR;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.ARG;

        /// <inheritdoc/>
        public int NumericCode => 032;

        /// <inheritdoc/>
        public string[] TLD => [".ar"];

        /// <inheritdoc/>
        public Region Region => Region.Americas;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthAmerica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.BO,
            Alpha2Code.BR,
            Alpha2Code.CL,
            Alpha2Code.PY,
            Alpha2Code.UY,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [ArsCurrency.Instance];

        /// <inheritdoc/>
        public string[] CallingCodes => ["54"];
    }
}
