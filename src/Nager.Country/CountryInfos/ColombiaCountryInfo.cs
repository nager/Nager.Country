using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Colombia
    /// </summary>
    public sealed class ColombiaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Colombia";

        /// <inheritdoc/>
        public string OfficialName => "Republic of Colombia";

        /// <inheritdoc/>
        public string NativeName => "Colombia";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.CO;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.COL;

        /// <inheritdoc/>
        public int NumericCode => 170;

        /// <inheritdoc/>
        public string[] TLD => [".co"];

        /// <inheritdoc/>
        public Region Region => Region.Americas;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthAmerica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.BR,
            Alpha2Code.EC,
            Alpha2Code.PA,
            Alpha2Code.PE,
            Alpha2Code.VE,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new CopCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["57"];
    }
}
