using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Philippines
    /// </summary>
    public sealed class PhilippinesCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Philippines";

        /// <inheritdoc/>
        public string OfficialName => "Republic of the Philippines";

        /// <inheritdoc/>
        public string NativeName => "Pilipinas";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.PH;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.PHL;

        /// <inheritdoc/>
        public int NumericCode => 608;

        /// <inheritdoc/>
        public string[] TLD => new [] { ".ph" };

        /// <inheritdoc/>
        public Region Region => Region.Asia;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthEasternAsia;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        /// <inheritdoc/>
        public ICurrency[] Currencies => new [] { new PhpCurrency() };

        /// <inheritdoc/>
        public string[] CallingCodes => new [] { "63" };
    }
}
