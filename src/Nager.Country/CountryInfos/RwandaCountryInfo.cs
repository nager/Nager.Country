using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Rwanda
    /// </summary>
    public sealed class RwandaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Rwanda";

        /// <inheritdoc/>
        public string OfficialName => "Republic of Rwanda";

        /// <inheritdoc/>
        public string NativeName => "Rwanda";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.RW;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.RWA;

        /// <inheritdoc/>
        public int NumericCode => 646;

        /// <inheritdoc/>
        public string[] TLD => [".rw"];

        /// <inheritdoc/>
        public Region Region => Region.Africa;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.EasternAfrica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.BI,
            Alpha2Code.CD,
            Alpha2Code.TZ,
            Alpha2Code.UG,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [RwfCurrency.Instance];

        /// <inheritdoc/>
        public string[] CallingCodes => ["250"];
    }
}
