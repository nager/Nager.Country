using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Montenegro
    /// </summary>
    public sealed class MontenegroCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Montenegro";

        /// <inheritdoc/>
        public string OfficialName => "Montenegro";

        /// <inheritdoc/>
        public string NativeName => "Црна Гора";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.ME;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.MNE;

        /// <inheritdoc/>
        public int NumericCode => 499;

        /// <inheritdoc/>
        public string[] TLD => [".me"];

        /// <inheritdoc/>
        public Region Region => Region.Europe;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.SoutheastEurope;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.AL,
            Alpha2Code.BA,
            Alpha2Code.HR,
            Alpha2Code.RS,
            Alpha2Code.XK,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new EurCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["382"];
    }
}
