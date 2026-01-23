using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Equatorial Guinea
    /// </summary>
    public sealed class EquatorialGuineaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Equatorial Guinea";

        /// <inheritdoc/>
        public string OfficialName => "Republic of Equatorial Guinea";

        /// <inheritdoc/>
        public string NativeName => "Equatorial Guinea";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.GQ;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.GNQ;

        /// <inheritdoc/>
        public int NumericCode => 226;

        /// <inheritdoc/>
        public string[] TLD => [".gq"];

        /// <inheritdoc/>
        public Region Region => Region.Africa;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.MiddleAfrica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.CM,
            Alpha2Code.GA,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [XafCurrency.Instance];

        /// <inheritdoc/>
        public string[] CallingCodes => ["240"];
    }
}
