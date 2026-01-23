using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// El Salvador
    /// </summary>
    public sealed class ElSalvadorCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "El Salvador";

        /// <inheritdoc/>
        public string OfficialName => "Republic of El Salvador";

        /// <inheritdoc/>
        public string NativeName => "El Salvador";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.SV;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.SLV;

        /// <inheritdoc/>
        public int NumericCode => 222;

        /// <inheritdoc/>
        public string[] TLD => [".sv"];

        /// <inheritdoc/>
        public Region Region => Region.Americas;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.CentralAmerica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.GT,
            Alpha2Code.HN,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies =>
        [
            SvcCurrency.Instance,
            UsdCurrency.Instance,
        ];

        /// <inheritdoc/>
        public string[] CallingCodes => ["503"];
    }
}
