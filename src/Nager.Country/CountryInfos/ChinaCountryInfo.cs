using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// China
    /// </summary>
    public sealed class ChinaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "China";

        /// <inheritdoc/>
        public string OfficialName => "People's Republic of China";

        /// <inheritdoc/>
        public string NativeName => "中国";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.CN;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.CHN;

        /// <inheritdoc/>
        public int NumericCode => 156;

        /// <inheritdoc/>
        public string[] TLD => [".cn", ".中国", ".中國", ".公司", ".网络"];

        /// <inheritdoc/>
        public Region Region => Region.Asia;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.EasternAsia;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.AF,
            Alpha2Code.BT,
            Alpha2Code.MM,
            Alpha2Code.HK,
            Alpha2Code.IN,
            Alpha2Code.KZ,
            Alpha2Code.KP,
            Alpha2Code.KG,
            Alpha2Code.LA,
            Alpha2Code.MO,
            Alpha2Code.MN,
            Alpha2Code.NP,
            Alpha2Code.PK,
            Alpha2Code.RU,
            Alpha2Code.TJ,
            Alpha2Code.VN,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new CnyCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["86"];
    }
}
