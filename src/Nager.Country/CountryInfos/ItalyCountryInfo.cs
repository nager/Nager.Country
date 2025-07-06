using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Italy
    /// </summary>
    public sealed class ItalyCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Italy";

        /// <inheritdoc/>
        public string OfficialName => "Italian Republic";

        /// <inheritdoc/>
        public string NativeName => "Italia";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.IT;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.ITA;

        /// <inheritdoc/>
        public int NumericCode => 380;

        /// <inheritdoc/>
        public string[] TLD => new [] { ".it" };

        /// <inheritdoc/>
        public Region Region => Region.Europe;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthernEurope;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.AT,
            Alpha2Code.FR,
            Alpha2Code.SM,
            Alpha2Code.SI,
            Alpha2Code.CH,
            Alpha2Code.VA,
        };

        /// <inheritdoc/>
        public ICurrency[] Currencies => new [] { new EurCurrency() };

        /// <inheritdoc/>
        public string[] CallingCodes => new [] { "39" };
    }
}
