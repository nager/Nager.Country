using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Panama
    /// </summary>
    public sealed class PanamaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Panama";

        /// <inheritdoc/>
        public string OfficialName => "Republic of Panama";

        /// <inheritdoc/>
        public string NativeName => "Panamá";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.PA;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.PAN;

        /// <inheritdoc/>
        public int NumericCode => 591;

        /// <inheritdoc/>
        public string[] TLD => [".pa"];

        /// <inheritdoc/>
        public Region Region => Region.Americas;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.CentralAmerica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.CO,
            Alpha2Code.CR,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies =>
        [
            PabCurrency.Instance,
            UsdCurrency.Instance,
        ];

        /// <inheritdoc/>
        public string[] CallingCodes => ["507"];
    }
}
