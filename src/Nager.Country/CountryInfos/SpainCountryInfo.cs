using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Spain
    /// </summary>
    public sealed class SpainCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Spain";

        /// <inheritdoc/>
        public string OfficialName => "Kingdom of Spain";

        /// <inheritdoc/>
        public string NativeName => "España";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.ES;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.ESP;

        /// <inheritdoc/>
        public int NumericCode => 724;

        /// <inheritdoc/>
        public string[] TLD => new [] { ".es" };

        /// <inheritdoc/>
        public Region Region => Region.Europe;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthernEurope;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.AD,
            Alpha2Code.FR,
            Alpha2Code.GI,
            Alpha2Code.PT,
            Alpha2Code.MA,
        };

        /// <inheritdoc/>
        public ICurrency[] Currencies => new [] { new EurCurrency() };

        /// <inheritdoc/>
        public string[] CallingCodes => new [] { "34" };
    }
}
