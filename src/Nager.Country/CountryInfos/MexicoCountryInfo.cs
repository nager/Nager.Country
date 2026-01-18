using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Mexico
    /// </summary>
    public sealed class MexicoCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Mexico";

        /// <inheritdoc/>
        public string OfficialName => "United Mexican States";

        /// <inheritdoc/>
        public string NativeName => "México";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.MX;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.MEX;

        /// <inheritdoc/>
        public int NumericCode => 484;

        /// <inheritdoc/>
        public string[] TLD => [".mx"];

        /// <inheritdoc/>
        public Region Region => Region.Americas;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.NorthAmerica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.BZ,
            Alpha2Code.GT,
            Alpha2Code.US,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [MxnCurrency.Instance];

        /// <inheritdoc/>
        public string[] CallingCodes => ["52"];
    }
}
