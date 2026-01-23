using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Cuba
    /// </summary>
    public sealed class CubaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Cuba";

        /// <inheritdoc/>
        public string OfficialName => "Republic of Cuba";

        /// <inheritdoc/>
        public string NativeName => "Cuba";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.CU;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.CUB;

        /// <inheritdoc/>
        public int NumericCode => 192;

        /// <inheritdoc/>
        public string[] TLD => [".cu"];

        /// <inheritdoc/>
        public Region Region => Region.Americas;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.Caribbean;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => [];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [
            CucCurrency.Instance,
            CupCurrency.Instance,
        ];

        /// <inheritdoc/>
        public string[] CallingCodes => ["53"];
    }
}
