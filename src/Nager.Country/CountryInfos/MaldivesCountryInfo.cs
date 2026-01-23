using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Maldives
    /// </summary>
    public sealed class MaldivesCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Maldives";

        /// <inheritdoc/>
        public string OfficialName => "Republic of the Maldives";

        /// <inheritdoc/>
        public string NativeName => "Maldives";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.MV;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.MDV;

        /// <inheritdoc/>
        public int NumericCode => 462;

        /// <inheritdoc/>
        public string[] TLD => [".mv"];

        /// <inheritdoc/>
        public Region Region => Region.Asia;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthernAsia;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => [];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [MvrCurrency.Instance];

        /// <inheritdoc/>
        public string[] CallingCodes => ["960"];
    }
}
