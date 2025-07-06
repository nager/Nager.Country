using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Guyana
    /// </summary>
    public sealed class GuyanaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Guyana";

        /// <inheritdoc/>
        public string OfficialName => "Co-operative Republic of Guyana";

        /// <inheritdoc/>
        public string NativeName => "Guyana";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.GY;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.GUY;

        /// <inheritdoc/>
        public int NumericCode => 328;

        /// <inheritdoc/>
        public string[] TLD => new [] { ".gy" };

        /// <inheritdoc/>
        public Region Region => Region.Americas;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthAmerica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.BR,
            Alpha2Code.SR,
            Alpha2Code.VE,
        };

        /// <inheritdoc/>
        public ICurrency[] Currencies => new [] { new GydCurrency() };

        /// <inheritdoc/>
        public string[] CallingCodes => new [] { "592" };
    }
}
