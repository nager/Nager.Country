using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Australia
    /// </summary>
    public sealed class AustraliaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Australia";

        /// <inheritdoc/>
        public string OfficialName => "Commonwealth of Australia";

        /// <inheritdoc/>
        public string NativeName => "Australia";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.AU;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.AUS;

        /// <inheritdoc/>
        public int NumericCode => 036;

        /// <inheritdoc/>
        public string[] TLD => [".au"];

        /// <inheritdoc/>
        public Region Region => Region.Oceania;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.AustraliaAndNewZealand;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => [];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new AudCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["61"];
    }
}
