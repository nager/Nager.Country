using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Somalia
    /// </summary>
    public sealed class SomaliaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Somalia";

        /// <inheritdoc/>
        public string OfficialName => "Federal Republic of Somalia";

        /// <inheritdoc/>
        public string NativeName => "Soomaaliya";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.SO;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.SOM;

        /// <inheritdoc/>
        public int NumericCode => 706;

        /// <inheritdoc/>
        public string[] TLD => [".so"];

        /// <inheritdoc/>
        public Region Region => Region.Africa;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.EasternAfrica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.DJ,
            Alpha2Code.ET,
            Alpha2Code.KE,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new SosCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["252"];
    }
}
