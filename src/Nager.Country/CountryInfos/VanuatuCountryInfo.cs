using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Vanuatu
    /// </summary>
    public sealed class VanuatuCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Vanuatu";

        /// <inheritdoc/>
        public string OfficialName => "Republic of Vanuatu";

        /// <inheritdoc/>
        public string NativeName => "Vanuatu";

        /// <inheritdoc/>
        public string Slug => "vanuatu";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.VU;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.VUT;

        /// <inheritdoc/>
        public int NumericCode => 548;

        /// <inheritdoc/>
        public string[] TLD => [".vu"];

        /// <inheritdoc/>
        public Region Region => Region.Oceania;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.Melanesia;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => [];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [CurrencyProvider.Vuv];

        /// <inheritdoc/>
        public string[] CallingCodes => ["678"];
    }
}
