using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Dominica
    /// </summary>
    public sealed class DominicaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Dominica";

        /// <inheritdoc/>
        public string OfficialName => "Commonwealth of Dominica";

        /// <inheritdoc/>
        public string NativeName => "Dominica";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.DM;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.DMA;

        /// <inheritdoc/>
        public int NumericCode => 212;

        /// <inheritdoc/>
        public string[] TLD => [".dm"];

        /// <inheritdoc/>
        public Region Region => Region.Americas;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.Caribbean;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => [];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [XcdCurrency.Instance];

        /// <inheritdoc/>
        public string[] CallingCodes => ["1767"];
    }
}
