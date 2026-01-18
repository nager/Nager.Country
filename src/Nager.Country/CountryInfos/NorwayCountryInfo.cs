using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Norway
    /// </summary>
    public sealed class NorwayCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Norway";

        /// <inheritdoc/>
        public string OfficialName => "Kingdom of Norway";

        /// <inheritdoc/>
        public string NativeName => "Norge";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.NO;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.NOR;

        /// <inheritdoc/>
        public int NumericCode => 578;

        /// <inheritdoc/>
        public string[] TLD => [".no"];

        /// <inheritdoc/>
        public Region Region => Region.Europe;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.NorthernEurope;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.FI,
            Alpha2Code.SE,
            Alpha2Code.RU,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [NokCurrency.Instance];

        /// <inheritdoc/>
        public string[] CallingCodes => ["47"];
    }
}
