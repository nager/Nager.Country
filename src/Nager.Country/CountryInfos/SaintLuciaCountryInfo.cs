using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Saint Lucia
    /// </summary>
    public sealed class SaintLuciaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Saint Lucia";

        /// <inheritdoc/>
        public string OfficialName => "Saint Lucia";

        /// <inheritdoc/>
        public string NativeName => "Saint Lucia";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.LC;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.LCA;

        /// <inheritdoc/>
        public int NumericCode => 662;

        /// <inheritdoc/>
        public string[] TLD => [".lc"];

        /// <inheritdoc/>
        public Region Region => Region.Americas;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.Caribbean;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => [];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new XcdCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["1758"];
    }
}
