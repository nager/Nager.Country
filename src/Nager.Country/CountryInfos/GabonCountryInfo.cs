using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Gabon
    /// </summary>
    public sealed class GabonCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Gabon";

        /// <inheritdoc/>
        public string OfficialName => "Gabonese Republic";

        /// <inheritdoc/>
        public string NativeName => "Gabon";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.GA;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.GAB;

        /// <inheritdoc/>
        public int NumericCode => 266;

        /// <inheritdoc/>
        public string[] TLD => [".ga"];

        /// <inheritdoc/>
        public Region Region => Region.Africa;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.MiddleAfrica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.CM,
            Alpha2Code.CG,
            Alpha2Code.GQ,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new XafCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["241"];
    }
}
