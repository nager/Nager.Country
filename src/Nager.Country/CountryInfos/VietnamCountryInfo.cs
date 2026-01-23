using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Vietnam
    /// </summary>
    public sealed class VietnamCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Vietnam";

        /// <inheritdoc/>
        public string OfficialName => "Socialist Republic of Vietnam";

        /// <inheritdoc/>
        public string NativeName => "Việt Nam";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.VN;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.VNM;

        /// <inheritdoc/>
        public int NumericCode => 704;

        /// <inheritdoc/>
        public string[] TLD => [".vn"];

        /// <inheritdoc/>
        public Region Region => Region.Asia;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthEasternAsia;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.KH,
            Alpha2Code.CN,
            Alpha2Code.LA,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [VndCurrency.Instance];

        /// <inheritdoc/>
        public string[] CallingCodes => ["84"];
    }
}
