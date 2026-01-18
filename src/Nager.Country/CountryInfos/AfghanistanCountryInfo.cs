using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Afghanistan
    /// </summary>
    public sealed class AfghanistanCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Afghanistan";

        /// <inheritdoc/>
        public string OfficialName => "Islamic Republic of Afghanistan";

        /// <inheritdoc/>
        public string NativeName => "افغانستان";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.AF;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.AFG;

        /// <inheritdoc/>
        public int NumericCode => 004;

        /// <inheritdoc/>
        public string[] TLD => [".af"];

        /// <inheritdoc/>
        public Region Region => Region.Asia;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthernAsia;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.IR,
            Alpha2Code.PK,
            Alpha2Code.TM,
            Alpha2Code.UZ,
            Alpha2Code.TJ,
            Alpha2Code.CN,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [AfnCurrency.Instance];

        /// <inheritdoc/>
        public string[] CallingCodes => ["93"];
    }
}
