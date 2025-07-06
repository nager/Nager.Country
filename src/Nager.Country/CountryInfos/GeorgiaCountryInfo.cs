using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Georgia
    /// </summary>
    public sealed class GeorgiaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Georgia";

        /// <inheritdoc/>
        public string OfficialName => "Georgia";

        /// <inheritdoc/>
        public string NativeName => "საქართველო";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.GE;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.GEO;

        /// <inheritdoc/>
        public int NumericCode => 268;

        /// <inheritdoc/>
        public string[] TLD => new [] { ".ge" };

        /// <inheritdoc/>
        public Region Region => Region.Asia;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.WesternAsia;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.AM,
            Alpha2Code.AZ,
            Alpha2Code.RU,
            Alpha2Code.TR,
        };

        /// <inheritdoc/>
        public ICurrency[] Currencies => new [] { new GelCurrency() };

        /// <inheritdoc/>
        public string[] CallingCodes => new [] { "995" };
    }
}
