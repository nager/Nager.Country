using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Anguilla
    /// </summary>
    public sealed class AnguillaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Anguilla";

        /// <inheritdoc/>
        public string OfficialName => "Anguilla";

        /// <inheritdoc/>
        public string NativeName => "Anguilla";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.AI;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.AIA;

        /// <inheritdoc/>
        public int NumericCode => 660;

        /// <inheritdoc/>
        public string[] TLD => [".ai"];

        /// <inheritdoc/>
        public Region Region => Region.Americas;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.Caribbean;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => [];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new XcdCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["1264"];
    }
}
