using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// United States Virgin Islands
    /// </summary>
    public sealed class UnitedStatesVirginIslandsCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "United States Virgin Islands";

        /// <inheritdoc/>
        public string OfficialName => "Virgin Islands of the United States";

        /// <inheritdoc/>
        public string NativeName => "Virgin Islands of the United States";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.VI;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.VIR;

        /// <inheritdoc/>
        public int NumericCode => 850;

        /// <inheritdoc/>
        public string[] TLD => [".vi"];

        /// <inheritdoc/>
        public Region Region => Region.Americas;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.Caribbean;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => [];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new UsdCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["1340"];
    }
}
