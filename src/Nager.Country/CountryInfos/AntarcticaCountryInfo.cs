namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Antarctica
    /// </summary>
    public sealed class AntarcticaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Antarctica";

        /// <inheritdoc/>
        public string OfficialName => "Antarctica";

        /// <inheritdoc/>
        public string NativeName => "Antarctica";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.AQ;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.ATA;

        /// <inheritdoc/>
        public int NumericCode => 010;

        /// <inheritdoc/>
        public string[] TLD => [".aq"];

        /// <inheritdoc/>
        public Region Region => Region.Antarctic;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.None;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => [];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [];

        /// <inheritdoc/>
        public string[] CallingCodes => [];
    }
}
