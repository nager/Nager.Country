using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Hong Kong
    /// </summary>
    public sealed class HongKongCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Hong Kong";

        /// <inheritdoc/>
        public string OfficialName => "Hong Kong Special Administrative Region of the People's Republic of China";

        /// <inheritdoc/>
        public string NativeName => "香港";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.HK;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.HKG;

        /// <inheritdoc/>
        public int NumericCode => 344;

        /// <inheritdoc/>
        public string[] TLD => [".hk", ".香港"];

        /// <inheritdoc/>
        public Region Region => Region.Asia;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.EasternAsia;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.CN,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new HkdCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["852"];
    }
}
