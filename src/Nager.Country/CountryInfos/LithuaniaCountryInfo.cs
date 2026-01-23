using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Lithuania
    /// </summary>
    public sealed class LithuaniaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Lithuania";

        /// <inheritdoc/>
        public string OfficialName => "Republic of Lithuania";

        /// <inheritdoc/>
        public string NativeName => "Lietuva";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.LT;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.LTU;

        /// <inheritdoc/>
        public int NumericCode => 440;

        /// <inheritdoc/>
        public string[] TLD => [".lt"];

        /// <inheritdoc/>
        public Region Region => Region.Europe;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.NorthernEurope;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.BY,
            Alpha2Code.LV,
            Alpha2Code.PL,
            Alpha2Code.RU,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [EurCurrency.Instance];

        /// <inheritdoc/>
        public string[] CallingCodes => ["370"];
    }
}
