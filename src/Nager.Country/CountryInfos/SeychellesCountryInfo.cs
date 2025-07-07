using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Seychelles
    /// </summary>
    public sealed class SeychellesCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Seychelles";

        /// <inheritdoc/>
        public string OfficialName => "Republic of Seychelles";

        /// <inheritdoc/>
        public string NativeName => "Seychelles";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.SC;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.SYC;

        /// <inheritdoc/>
        public int NumericCode => 690;

        /// <inheritdoc/>
        public string[] TLD => [".sc"];

        /// <inheritdoc/>
        public Region Region => Region.Africa;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.EasternAfrica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => [];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new ScrCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["248"];
    }
}
