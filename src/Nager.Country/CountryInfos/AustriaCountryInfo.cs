using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Austria
    /// </summary>
    public sealed class AustriaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Austria";

        /// <inheritdoc/>
        public string OfficialName => "Republic of Austria";

        /// <inheritdoc/>
        public string NativeName => "Österreich";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.AT;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.AUT;

        /// <inheritdoc/>
        public int NumericCode => 040;

        /// <inheritdoc/>
        public string[] TLD => [".at"];

        /// <inheritdoc/>
        public Region Region => Region.Europe;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.WesternEurope;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.CZ,
            Alpha2Code.DE,
            Alpha2Code.HU,
            Alpha2Code.IT,
            Alpha2Code.LI,
            Alpha2Code.SK,
            Alpha2Code.SI,
            Alpha2Code.CH,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [EurCurrency.Instance];

        /// <inheritdoc/>
        public string[] CallingCodes => ["43"];

    }
}
