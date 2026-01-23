using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Spain
    /// </summary>
    public sealed class SpainCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Spain";

        /// <inheritdoc/>
        public string OfficialName => "Kingdom of Spain";

        /// <inheritdoc/>
        public string NativeName => "España";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.ES;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.ESP;

        /// <inheritdoc/>
        public int NumericCode => 724;

        /// <inheritdoc/>
        public string[] TLD => [".es"];

        /// <inheritdoc/>
        public Region Region => Region.Europe;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthernEurope;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.AD,
            Alpha2Code.FR,
            Alpha2Code.GI,
            Alpha2Code.PT,
            Alpha2Code.MA,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [EurCurrency.Instance];

        /// <inheritdoc/>
        public string[] CallingCodes => ["34"];
    }
}
