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
        public string[] TLD => [".ph"];

        /// <inheritdoc/>
        public Region Region => Region.Asia;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthEasternAsia;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => [];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [PhpCurrency.Instance];

        /// <inheritdoc/>
        public string[] CallingCodes => ["63"];
    }
}
