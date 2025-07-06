using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Antigua and Barbuda
    /// </summary>
    public sealed class AntiguaAndBarbudaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Antigua and Barbuda";

        /// <inheritdoc/>
        public string OfficialName => "Antigua and Barbuda";

        /// <inheritdoc/>
        public string NativeName => "Antigua and Barbuda";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.AG;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.ATG;

        /// <inheritdoc/>
        public int NumericCode => 028;

        /// <inheritdoc/>
        public string[] TLD => [".ag"];

        /// <inheritdoc/>
        public Region Region => Region.Americas;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.Caribbean;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => [];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new XcdCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["1268"];
    }
}
