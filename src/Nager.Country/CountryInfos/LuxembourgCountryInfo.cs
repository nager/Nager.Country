using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Luxembourg
    /// </summary>
    public sealed class LuxembourgCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Luxembourg";

        /// <inheritdoc/>
        public string OfficialName => "Grand Duchy of Luxembourg";

        /// <inheritdoc/>
        public string NativeName => "Luxembourg";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.LU;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.LUX;

        /// <inheritdoc/>
        public int NumericCode => 442;

        /// <inheritdoc/>
        public string[] TLD => [".lu"];

        /// <inheritdoc/>
        public Region Region => Region.Europe;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.WesternEurope;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.BE,
            Alpha2Code.FR,
            Alpha2Code.DE,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new EurCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["352"];
    }
}
