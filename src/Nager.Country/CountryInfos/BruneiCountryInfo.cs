using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Brunei
    /// </summary>
    public sealed class BruneiCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Brunei";

        /// <inheritdoc/>
        public string OfficialName => "Nation of Brunei, Abode of Peace";

        /// <inheritdoc/>
        public string NativeName => "Negara Brunei Darussalam";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.BN;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.BRN;

        /// <inheritdoc/>
        public int NumericCode => 096;

        /// <inheritdoc/>
        public string[] TLD => [".bn"];

        /// <inheritdoc/>
        public Region Region => Region.Asia;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthEasternAsia;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.MY,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [BndCurrency.Instance];

        /// <inheritdoc/>
        public string[] CallingCodes => ["673"];
    }
}
