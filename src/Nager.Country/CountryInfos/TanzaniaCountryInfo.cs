using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Tanzania
    /// </summary>
    public sealed class TanzaniaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Tanzania";

        /// <inheritdoc/>
        public string OfficialName => "United Republic of Tanzania";

        /// <inheritdoc/>
        public string NativeName => "Tanzania";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.TZ;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.TZA;

        /// <inheritdoc/>
        public int NumericCode => 834;

        /// <inheritdoc/>
        public string[] TLD => [".tz"];

        /// <inheritdoc/>
        public Region Region => Region.Africa;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.EasternAfrica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.BI,
            Alpha2Code.CD,
            Alpha2Code.KE,
            Alpha2Code.MW,
            Alpha2Code.MZ,
            Alpha2Code.RW,
            Alpha2Code.UG,
            Alpha2Code.ZM,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [TzsCurrency.Instance];

        /// <inheritdoc/>
        public string[] CallingCodes => ["255"];
    }
}
