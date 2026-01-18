using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Portugal
    /// </summary>
    public sealed class PortugalCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Portugal";

        /// <inheritdoc/>
        public string OfficialName => "Portuguese Republic";

        /// <inheritdoc/>
        public string NativeName => "Portugal";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.PT;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.PRT;

        /// <inheritdoc/>
        public int NumericCode => 620;

        /// <inheritdoc/>
        public string[] TLD => [".pt"];

        /// <inheritdoc/>
        public Region Region => Region.Europe;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthernEurope;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.ES,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [EurCurrency.Instance];

        /// <inheritdoc/>
        public string[] CallingCodes => ["351"];
    }
}
