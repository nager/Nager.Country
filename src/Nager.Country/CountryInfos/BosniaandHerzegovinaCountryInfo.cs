using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Bosnia and Herzegovina
    /// </summary>
    public sealed class BosniaandHerzegovinaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Bosnia and Herzegovina";

        /// <inheritdoc/>
        public string OfficialName => "Bosnia and Herzegovina";

        /// <inheritdoc/>
        public string NativeName => "Bosna i Hercegovina";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.BA;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.BIH;

        /// <inheritdoc/>
        public int NumericCode => 070;

        /// <inheritdoc/>
        public string[] TLD => [".ba"];

        /// <inheritdoc/>
        public Region Region => Region.Europe;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthernEurope;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.HR,
            Alpha2Code.ME,
            Alpha2Code.RS,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new BamCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["387"];
    }
}
