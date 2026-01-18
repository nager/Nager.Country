using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Costa Rica
    /// </summary>
    public sealed class CostaRicaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Costa Rica";

        /// <inheritdoc/>
        public string OfficialName => "Republic of Costa Rica";

        /// <inheritdoc/>
        public string NativeName => "Costa Rica";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.CR;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.CRI;

        /// <inheritdoc/>
        public int NumericCode => 188;

        /// <inheritdoc/>
        public string[] TLD => [".cr"];

        /// <inheritdoc/>
        public Region Region => Region.Americas;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.CentralAmerica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.NI,
            Alpha2Code.PA,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [CrcCurrency.Instance];

        /// <inheritdoc/>
        public string[] CallingCodes => ["506"];
    }
}
