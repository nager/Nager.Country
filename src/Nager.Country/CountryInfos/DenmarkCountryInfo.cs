using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Denmark
    /// </summary>
    public sealed class DenmarkCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Denmark";

        /// <inheritdoc/>
        public string OfficialName => "Kingdom of Denmark";

        /// <inheritdoc/>
        public string NativeName => "Danmark";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.DK;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.DNK;

        /// <inheritdoc/>
        public int NumericCode => 208;

        /// <inheritdoc/>
        public string[] TLD => [".dk"];

        /// <inheritdoc/>
        public Region Region => Region.Europe;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.NorthernEurope;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.DE,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new DkkCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["45"];
    }
}
