using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Turks and Caicos Islands
    /// </summary>
    public sealed class TurksAndCaicosIslandsCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Turks and Caicos Islands";

        /// <inheritdoc/>
        public string OfficialName => "Turks and Caicos Islands";

        /// <inheritdoc/>
        public string NativeName => "Turks and Caicos Islands";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.TC;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.TCA;

        /// <inheritdoc/>
        public int NumericCode => 796;

        /// <inheritdoc/>
        public string[] TLD => [".tc"];

        /// <inheritdoc/>
        public Region Region => Region.Americas;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.Caribbean;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => [];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [UsdCurrency.Instance];

        /// <inheritdoc/>
        public string[] CallingCodes => ["1649"];
    }
}
