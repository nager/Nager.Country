using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Grenada
    /// </summary>
    public sealed class GrenadaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Grenada";

        /// <inheritdoc/>
        public string OfficialName => "Grenada";

        /// <inheritdoc/>
        public string NativeName => "Grenada";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.GD;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.GRD;

        /// <inheritdoc/>
        public int NumericCode => 308;

        /// <inheritdoc/>
        public string[] TLD => [".gd"];

        /// <inheritdoc/>
        public Region Region => Region.Americas;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.Caribbean;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => [];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [XcdCurrency.Instance];

        /// <inheritdoc/>
        public string[] CallingCodes => ["1473"];
    }
}
