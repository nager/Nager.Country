using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Central African Republic
    /// </summary>
    public sealed class CentralAfricanRepublicCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Central African Republic";

        /// <inheritdoc/>
        public string OfficialName => "Central African Republic";

        /// <inheritdoc/>
        public string NativeName => "Ködörösêse tî Bêafrîka";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.CF;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.CAF;

        /// <inheritdoc/>
        public int NumericCode => 140;

        /// <inheritdoc/>
        public string[] TLD => [".cf"];

        /// <inheritdoc/>
        public Region Region => Region.Africa;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.MiddleAfrica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.CM,
            Alpha2Code.TD,
            Alpha2Code.CD,
            Alpha2Code.CG,
            Alpha2Code.SS,
            Alpha2Code.SD,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new XafCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["236"];
    }
}
