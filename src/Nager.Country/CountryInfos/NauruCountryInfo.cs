using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Nauru
    /// </summary>
    public sealed class NauruCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Nauru";

        /// <inheritdoc/>
        public string OfficialName => "Republic of Nauru";

        /// <inheritdoc/>
        public string NativeName => "Nauru";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.NR;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.NRU;

        /// <inheritdoc/>
        public int NumericCode => 520;

        /// <inheritdoc/>
        public string[] TLD => [".nr"];

        /// <inheritdoc/>
        public Region Region => Region.Oceania;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.Micronesia;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => [];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new AudCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["674"];
    }
}
