using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// French Guiana
    /// </summary>
    public sealed class FrenchGuianaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "French Guiana";

        /// <inheritdoc/>
        public string OfficialName => "Guiana";

        /// <inheritdoc/>
        public string NativeName => "Guyane française";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.GF;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.GUF;

        /// <inheritdoc/>
        public int NumericCode => 254;

        /// <inheritdoc/>
        public string[] TLD => [".gf"];

        /// <inheritdoc/>
        public Region Region => Region.Americas;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthAmerica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.BR,
            Alpha2Code.SR,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new EurCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["594"];
    }
}
