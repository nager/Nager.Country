using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Djibouti
    /// </summary>
    public sealed class DjiboutiCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Djibouti";

        /// <inheritdoc/>
        public string OfficialName => "Republic of Djibouti";

        /// <inheritdoc/>
        public string NativeName => "Djibouti";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.DJ;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.DJI;

        /// <inheritdoc/>
        public int NumericCode => 262;

        /// <inheritdoc/>
        public string[] TLD => [".dj"];

        /// <inheritdoc/>
        public Region Region => Region.Africa;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.EasternAfrica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.ER,
            Alpha2Code.ET,
            Alpha2Code.SO,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new DjfCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["253"];
    }
}
