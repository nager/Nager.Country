using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Bulgaria
    /// </summary>
    public sealed class BulgariaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Bulgaria";

        /// <inheritdoc/>
        public string OfficialName => "Republic of Bulgaria";

        /// <inheritdoc/>
        public string NativeName => "България";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.BG;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.BGR;

        /// <inheritdoc/>
        public int NumericCode => 100;

        /// <inheritdoc/>
        public string[] TLD => [".bg"];

        /// <inheritdoc/>
        public Region Region => Region.Europe;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.EasternEurope;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.GR,
            Alpha2Code.MK,
            Alpha2Code.RO,
            Alpha2Code.RS,
            Alpha2Code.TR,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [EurCurrency.Instance];

        /// <inheritdoc/>
        public string[] CallingCodes => ["359"];
    }
}
