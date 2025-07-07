using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Myanmar
    /// </summary>
    public sealed class MyanmarCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Myanmar";

        /// <inheritdoc/>
        public string OfficialName => "Republic of the Union of Myanmar";

        /// <inheritdoc/>
        public string NativeName => "Myanma";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.MM;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.MMR;

        /// <inheritdoc/>
        public int NumericCode => 104;

        /// <inheritdoc/>
        public string[] TLD => [".mm"];

        /// <inheritdoc/>
        public Region Region => Region.Asia;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthEasternAsia;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.BD,
            Alpha2Code.CN,
            Alpha2Code.IN,
            Alpha2Code.LA,
            Alpha2Code.TH,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new MmkCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["95"];
    }
}
