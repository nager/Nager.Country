using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Belgium
    /// </summary>
    public class BelgiumCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Belgium";
        /// <inheritdoc/>
        public string OfficialName => "Kingdom of Belgium";
        /// <inheritdoc/>
        public string NativeName => "België";
        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.BE;
        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.BEL;
        /// <inheritdoc/>
        public int NumericCode => 056;
        /// <inheritdoc/>
        public string[] TLD => new [] { ".be" };

        /// <inheritdoc/>
        public Region Region => Region.Europe;
        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.WesternEurope;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.FR,
            Alpha2Code.DE,
            Alpha2Code.LU,
            Alpha2Code.NL,
        };

        /// <inheritdoc/>
        public ICurrency[] Currencies => new [] { new EurCurrency() };
        /// <inheritdoc/>
        public string[] CallingCodes => new [] { "32" };
    }
}
