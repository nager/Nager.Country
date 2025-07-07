using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Switzerland
    /// </summary>
    public sealed class SwitzerlandCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Switzerland";

        /// <inheritdoc/>
        public string OfficialName => "Swiss Confederation";

        /// <inheritdoc/>
        public string NativeName => "Schweiz";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.CH;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.CHE;

        /// <inheritdoc/>
        public int NumericCode => 756;

        /// <inheritdoc/>
        public string[] TLD => [".ch"];

        /// <inheritdoc/>
        public Region Region => Region.Europe;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.WesternEurope;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.AT,
            Alpha2Code.FR,
            Alpha2Code.IT,
            Alpha2Code.LI,
            Alpha2Code.DE,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new ChfCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["41"];
    }
}
