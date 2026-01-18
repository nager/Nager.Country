using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Gibraltar
    /// </summary>
    public sealed class GibraltarCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Gibraltar";

        /// <inheritdoc/>
        public string OfficialName => "Gibraltar";

        /// <inheritdoc/>
        public string NativeName => "Gibraltar";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.GI;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.GIB;

        /// <inheritdoc/>
        public int NumericCode => 292;

        /// <inheritdoc/>
        public string[] TLD => [".gi"];

        /// <inheritdoc/>
        public Region Region => Region.Europe;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthernEurope;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.ES,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [GipCurrency.Instance];

        /// <inheritdoc/>
        public string[] CallingCodes => ["350"];
    }
}
