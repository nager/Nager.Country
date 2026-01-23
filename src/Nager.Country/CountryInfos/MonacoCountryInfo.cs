using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Monaco
    /// </summary>
    public sealed class MonacoCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Monaco";

        /// <inheritdoc/>
        public string OfficialName => "Principality of Monaco";

        /// <inheritdoc/>
        public string NativeName => "Monaco";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.MC;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.MCO;

        /// <inheritdoc/>
        public int NumericCode => 492;

        /// <inheritdoc/>
        public string[] TLD => [".mc"];

        /// <inheritdoc/>
        public Region Region => Region.Europe;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.WesternEurope;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.FR,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [EurCurrency.Instance];

        /// <inheritdoc/>
        public string[] CallingCodes => ["377"];
    }
}
