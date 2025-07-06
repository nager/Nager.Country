using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Liechtenstein
    /// </summary>
    public sealed class LiechtensteinCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Liechtenstein";

        /// <inheritdoc/>
        public string OfficialName => "Principality of Liechtenstein";

        /// <inheritdoc/>
        public string NativeName => "Liechtenstein";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.LI;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.LIE;

        /// <inheritdoc/>
        public int NumericCode => 438;

        /// <inheritdoc/>
        public string[] TLD => new [] { ".li" };

        /// <inheritdoc/>
        public Region Region => Region.Europe;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.WesternEurope;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.AT,
            Alpha2Code.CH,
        };

        /// <inheritdoc/>
        public ICurrency[] Currencies => new [] { new ChfCurrency() };

        /// <inheritdoc/>
        public string[] CallingCodes => new [] { "423" };
    }
}
