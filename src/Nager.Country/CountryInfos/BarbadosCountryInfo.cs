using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Barbados
    /// </summary>
    public sealed class BarbadosCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Barbados";

        /// <inheritdoc/>
        public string OfficialName => "Barbados";

        /// <inheritdoc/>
        public string NativeName => "Barbados";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.BB;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.BRB;

        /// <inheritdoc/>
        public int NumericCode => 052;

        /// <inheritdoc/>
        public string[] TLD => [".bb"];

        /// <inheritdoc/>
        public Region Region => Region.Americas;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.Caribbean;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => [];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [BbdCurrency.Instance];

        /// <inheritdoc/>
        public string[] CallingCodes => ["1246"];
    }
}
