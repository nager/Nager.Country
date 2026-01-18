using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// British Virgin Islands
    /// </summary>
    public sealed class BritishVirginIslandsCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "British Virgin Islands";

        /// <inheritdoc/>
        public string OfficialName => "Virgin Islands";

        /// <inheritdoc/>
        public string NativeName => "British Virgin Islands";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.VG;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.VGB;

        /// <inheritdoc/>
        public int NumericCode => 092;

        /// <inheritdoc/>
        public string[] TLD => [".vg"];

        /// <inheritdoc/>
        public Region Region => Region.Americas;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.Caribbean;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => [];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [UsdCurrency.Instance];

        /// <inheritdoc/>
        public string[] CallingCodes => ["1284"];
    }
}
