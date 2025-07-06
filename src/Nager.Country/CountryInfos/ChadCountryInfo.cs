using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Chad
    /// </summary>
    public sealed class ChadCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Chad";

        /// <inheritdoc/>
        public string OfficialName => "Republic of Chad";

        /// <inheritdoc/>
        public string NativeName => "Tchad";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.TD;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.TCD;

        /// <inheritdoc/>
        public int NumericCode => 148;

        /// <inheritdoc/>
        public string[] TLD => new [] { ".td" };

        /// <inheritdoc/>
        public Region Region => Region.Africa;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.MiddleAfrica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.CM,
            Alpha2Code.CF,
            Alpha2Code.LY,
            Alpha2Code.NE,
            Alpha2Code.NG,
            Alpha2Code.SS,
        };

        /// <inheritdoc/>
        public ICurrency[] Currencies => new [] { new XafCurrency() };

        /// <inheritdoc/>
        public string[] CallingCodes => new [] { "235" };
    }
}
