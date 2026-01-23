using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Guam
    /// </summary>
    public sealed class GuamCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Guam";

        /// <inheritdoc/>
        public string OfficialName => "Guam";

        /// <inheritdoc/>
        public string NativeName => "Guam";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.GU;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.GUM;

        /// <inheritdoc/>
        public int NumericCode => 316;

        /// <inheritdoc/>
        public string[] TLD => [".gu"];

        /// <inheritdoc/>
        public Region Region => Region.Oceania;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.Micronesia;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => [];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [UsdCurrency.Instance];

        /// <inheritdoc/>
        public string[] CallingCodes => ["1671"];
    }
}
