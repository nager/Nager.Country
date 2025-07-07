using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Isle of Man
    /// </summary>
    public sealed class IsleofManCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Isle of Man";

        /// <inheritdoc/>
        public string OfficialName => "Isle of Man";

        /// <inheritdoc/>
        public string NativeName => "Isle of Man";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.IM;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.IMN;

        /// <inheritdoc/>
        public int NumericCode => 833;

        /// <inheritdoc/>
        public string[] TLD => [".im"];

        /// <inheritdoc/>
        public Region Region => Region.Europe;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.NorthernEurope;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => [];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new GbpCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["44"];
    }
}
