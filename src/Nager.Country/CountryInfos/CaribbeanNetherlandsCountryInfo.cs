using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Caribbean Netherlands
    /// </summary>
    public sealed class CaribbeanNetherlandsCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Caribbean Netherlands";

        /// <inheritdoc/>
        public string OfficialName => "Caribbean Netherlands";

        /// <inheritdoc/>
        public string NativeName => "Caribbean Netherlands";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.BQ;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.BES;

        /// <inheritdoc/>
        public int NumericCode => 535;

        /// <inheritdoc/>
        public string[] TLD => [".bq", ".nl"];

        /// <inheritdoc/>
        public Region Region => Region.Americas;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.Caribbean;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => [];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new UsdCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["599"];
    }
}
