using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Falkland Islands
    /// </summary>
    public sealed class FalklandIslandsCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Falkland Islands";

        /// <inheritdoc/>
        public string OfficialName => "Falkland Islands";

        /// <inheritdoc/>
        public string NativeName => "Falkland Islands";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.FK;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.FLK;

        /// <inheritdoc/>
        public int NumericCode => 238;

        /// <inheritdoc/>
        public string[] TLD => [".fk"];

        /// <inheritdoc/>
        public Region Region => Region.Americas;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthAmerica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => [];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [FkpCurrency.Instance];

        /// <inheritdoc/>
        public string[] CallingCodes => ["500"];
    }
}
