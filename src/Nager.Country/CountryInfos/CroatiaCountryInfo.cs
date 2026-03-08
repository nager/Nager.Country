using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Croatia
    /// </summary>
    public sealed class CroatiaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Croatia";

        /// <inheritdoc/>
        public string OfficialName => "Republic of Croatia";

        /// <inheritdoc/>
        public string NativeName => "Hrvatska";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.HR;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.HRV;

        /// <inheritdoc/>
        public int NumericCode => 191;

        /// <inheritdoc/>
        public string[] TLD => [".hr"];

        /// <inheritdoc/>
        public Region Region => Region.Europe;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.SoutheastEurope;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.BA,
            Alpha2Code.HU,
            Alpha2Code.ME,
            Alpha2Code.RS,
            Alpha2Code.SI,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new EurCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["385"];
    }
}
