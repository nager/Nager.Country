using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Cameroon
    /// </summary>
    public sealed class CameroonCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Cameroon";

        /// <inheritdoc/>
        public string OfficialName => "Republic of Cameroon";

        /// <inheritdoc/>
        public string NativeName => "Cameroon";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.CM;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.CMR;

        /// <inheritdoc/>
        public int NumericCode => 120;

        /// <inheritdoc/>
        public string[] TLD => [".cm"];

        /// <inheritdoc/>
        public Region Region => Region.Africa;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.MiddleAfrica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.CF,
            Alpha2Code.TD,
            Alpha2Code.CG,
            Alpha2Code.GQ,
            Alpha2Code.GA,
            Alpha2Code.NG,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new XafCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["237"];
    }
}
