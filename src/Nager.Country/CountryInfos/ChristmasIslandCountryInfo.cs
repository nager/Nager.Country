using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Christmas Island
    /// </summary>
    public sealed class ChristmasIslandCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Christmas Island";

        /// <inheritdoc/>
        public string OfficialName => "Territory of Christmas Island";

        /// <inheritdoc/>
        public string NativeName => "Christmas Island";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.CX;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.CXR;

        /// <inheritdoc/>
        public int NumericCode => 162;

        /// <inheritdoc/>
        public string[] TLD => [".cx"];

        /// <inheritdoc/>
        public Region Region => Region.Oceania;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.AustraliaAndNewZealand;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => [];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [AudCurrency.Instance];

        /// <inheritdoc/>
        public string[] CallingCodes => ["61"];
    }
}
