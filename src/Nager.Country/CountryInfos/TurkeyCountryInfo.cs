using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Turkey
    /// </summary>
    public sealed class TurkeyCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Türkiye";

        /// <inheritdoc/>
        public string OfficialName => "Republic of Türkiye";

        /// <inheritdoc/>
        public string NativeName => "Türkiye";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.TR;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.TUR;

        /// <inheritdoc/>
        public int NumericCode => 792;

        /// <inheritdoc/>
        public string[] TLD => [".tr"];

        /// <inheritdoc/>
        public Region Region => Region.Asia;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.WesternAsia;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.AM,
            Alpha2Code.AZ,
            Alpha2Code.BG,
            Alpha2Code.GE,
            Alpha2Code.GR,
            Alpha2Code.IR,
            Alpha2Code.IQ,
            Alpha2Code.SY,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [TryCurrency.Instance];

        /// <inheritdoc/>
        public string[] CallingCodes => ["90"];
    }
}
