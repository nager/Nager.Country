using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Réunion
    /// </summary>
    public sealed class ReunionCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Réunion";

        /// <inheritdoc/>
        public string OfficialName => "Réunion Island";

        /// <inheritdoc/>
        public string NativeName => "La Réunion";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.RE;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.REU;

        /// <inheritdoc/>
        public int NumericCode => 638;

        /// <inheritdoc/>
        public string[] TLD => [".re"];

        /// <inheritdoc/>
        public Region Region => Region.Africa;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.EasternAfrica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => [];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new EurCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["262"];
    }
}
