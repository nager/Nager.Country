using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Pakistan
    /// </summary>
    public sealed class PakistanCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Pakistan";

        /// <inheritdoc/>
        public string OfficialName => "Islamic Republic of Pakistan";

        /// <inheritdoc/>
        public string NativeName => "Pakistan";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.PK;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.PAK;

        /// <inheritdoc/>
        public int NumericCode => 586;

        /// <inheritdoc/>
        public string[] TLD => [".pk"];

        /// <inheritdoc/>
        public Region Region => Region.Asia;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthernAsia;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.AF,
            Alpha2Code.CN,
            Alpha2Code.IN,
            Alpha2Code.IR,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [PkrCurrency.Instance];

        /// <inheritdoc/>
        public string[] CallingCodes => ["92"];
    }
}
