using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Germany
    /// </summary>
    public class GermanyCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Germany";
        /// <inheritdoc/>
        public string OfficialName => "Federal Republic of Germany";
        /// <inheritdoc/>
        public string NativeName => "Deutschland";
        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.DE;
        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.DEU;
        /// <inheritdoc/>
        public int NumericCode => 276;
        /// <inheritdoc/>
        public string[] TLD => new [] { ".de" };

        /// <inheritdoc/>
        public Region Region => Region.Europe;
        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.WesternEurope;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.AT,
            Alpha2Code.BE,
            Alpha2Code.CZ,
            Alpha2Code.DK,
            Alpha2Code.FR,
            Alpha2Code.LU,
            Alpha2Code.NL,
            Alpha2Code.PL,
            Alpha2Code.CH,
        };

        /// <inheritdoc/>
        public ICurrency[] Currencies => new [] { new EurCurrency() };
        /// <inheritdoc/>
        public string[] CallingCodes => new [] { "49" };
    }
}
