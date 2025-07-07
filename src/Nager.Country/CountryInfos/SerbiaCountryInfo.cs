using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Serbia
    /// </summary>
    public sealed class SerbiaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Serbia";

        /// <inheritdoc/>
        public string OfficialName => "Republic of Serbia";

        /// <inheritdoc/>
        public string NativeName => "Србија";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.RS;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.SRB;

        /// <inheritdoc/>
        public int NumericCode => 688;

        /// <inheritdoc/>
        public string[] TLD =>
        [
            ".rs",
            ".срб",
        ];

        /// <inheritdoc/>
        public Region Region => Region.Europe;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthernEurope;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.BA,
            Alpha2Code.BG,
            Alpha2Code.HR,
            Alpha2Code.HU,
            Alpha2Code.MK,
            Alpha2Code.ME,
            Alpha2Code.RO,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new RsdCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["381"];
    }
}
