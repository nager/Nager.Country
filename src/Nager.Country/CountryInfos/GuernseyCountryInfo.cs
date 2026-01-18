using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Guernsey
    /// </summary>
    public sealed class GuernseyCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Guernsey";

        /// <inheritdoc/>
        public string OfficialName => "Bailiwick of Guernsey";

        /// <inheritdoc/>
        public string NativeName => "Guernsey";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.GG;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.GGY;

        /// <inheritdoc/>
        public int NumericCode => 831;

        /// <inheritdoc/>
        public string[] TLD => [".gg"];

        /// <inheritdoc/>
        public Region Region => Region.Europe;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.NorthernEurope;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => [];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [GbpCurrency.Instance];

        /// <inheritdoc/>
        public string[] CallingCodes => ["44"];
    }
}
