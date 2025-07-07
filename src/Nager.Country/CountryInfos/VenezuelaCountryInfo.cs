using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Venezuela
    /// </summary>
    public sealed class VenezuelaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Venezuela";

        /// <inheritdoc/>
        public string OfficialName => "Bolivarian Republic of Venezuela";

        /// <inheritdoc/>
        public string NativeName => "Venezuela";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.VE;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.VEN;

        /// <inheritdoc/>
        public int NumericCode => 862;

        /// <inheritdoc/>
        public string[] TLD => [".ve"];

        /// <inheritdoc/>
        public Region Region => Region.Americas;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthAmerica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.BR,
            Alpha2Code.CO,
            Alpha2Code.GY,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new VefCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["58"];
    }
}
