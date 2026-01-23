using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Mayotte
    /// </summary>
    public sealed class MayotteCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Mayotte";

        /// <inheritdoc/>
        public string OfficialName => "Department of Mayotte";

        /// <inheritdoc/>
        public string NativeName => "Mayotte";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.YT;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.MYT;

        /// <inheritdoc/>
        public int NumericCode => 175;

        /// <inheritdoc/>
        public string[] TLD => [".yt"];

        /// <inheritdoc/>
        public Region Region => Region.Africa;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.EasternAfrica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => [];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [EurCurrency.Instance];

        /// <inheritdoc/>
        public string[] CallingCodes => ["262"];
    }
}
