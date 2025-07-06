using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Dominican Republic
    /// </summary>
    public sealed class DominicanRepublicCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Dominican Republic";

        /// <inheritdoc/>
        public string OfficialName => "Dominican Republic";

        /// <inheritdoc/>
        public string NativeName => "República Dominicana";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.DO;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.DOM;

        /// <inheritdoc/>
        public int NumericCode => 214;

        /// <inheritdoc/>
        public string[] TLD => new [] { ".do" };

        /// <inheritdoc/>
        public Region Region => Region.Americas;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.Caribbean;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.HT,
        };

        /// <inheritdoc/>
        public ICurrency[] Currencies => new [] { new DopCurrency() };

        /// <inheritdoc/>
        public string[] CallingCodes => new [] { "1809", "1829", "1849" };
    }
}
