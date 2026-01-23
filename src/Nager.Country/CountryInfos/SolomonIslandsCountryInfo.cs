using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Solomon Islands
    /// </summary>
    public sealed class SolomonIslandsCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Solomon Islands";

        /// <inheritdoc/>
        public string OfficialName => "Solomon Islands";

        /// <inheritdoc/>
        public string NativeName => "Solomon Islands";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.SB;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.SLB;

        /// <inheritdoc/>
        public int NumericCode => 090;

        /// <inheritdoc/>
        public string[] TLD => [".sb"];

        /// <inheritdoc/>
        public Region Region => Region.Oceania;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.Melanesia;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => [];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [SbdCurrency.Instance];

        /// <inheritdoc/>
        public string[] CallingCodes => ["677"];
    }
}
