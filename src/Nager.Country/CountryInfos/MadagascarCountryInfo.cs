using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Madagascar
    /// </summary>
    public sealed class MadagascarCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Madagascar";

        /// <inheritdoc/>
        public string OfficialName => "Republic of Madagascar";

        /// <inheritdoc/>
        public string NativeName => "Madagasikara";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.MG;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.MDG;

        /// <inheritdoc/>
        public int NumericCode => 450;

        /// <inheritdoc/>
        public string[] TLD => [".mg"];

        /// <inheritdoc/>
        public Region Region => Region.Africa;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.EasternAfrica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => [];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new MgaCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["261"];
    }
}
