using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Puerto Rico
    /// </summary>
    public sealed class PuertoRicoCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Puerto Rico";

        /// <inheritdoc/>
        public string OfficialName => "Commonwealth of Puerto Rico";

        /// <inheritdoc/>
        public string NativeName => "Puerto Rico";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.PR;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.PRI;

        /// <inheritdoc/>
        public int NumericCode => 630;

        /// <inheritdoc/>
        public string[] TLD => [".pr"];

        /// <inheritdoc/>
        public Region Region => Region.Americas;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.Caribbean;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => [];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [UsdCurrency.Instance];

        /// <inheritdoc/>
        public string[] CallingCodes =>
        [
            "1787",
            "1939",
        ];
    }
}
