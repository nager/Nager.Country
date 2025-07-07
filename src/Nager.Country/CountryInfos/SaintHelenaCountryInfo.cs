using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Saint Helena
    /// </summary>
    public sealed class SaintHelenaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Saint Helena, Ascension and Tristan da Cunha";

        /// <inheritdoc/>
        public string OfficialName => "Saint Helena, Ascension and Tristan da Cunha";

        /// <inheritdoc/>
        public string NativeName => "Saint Helena";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.SH;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.SHN;

        /// <inheritdoc/>
        public int NumericCode => 654;

        /// <inheritdoc/>
        public string[] TLD =>
        [
            ".sh",
            ".ac",
        ];

        /// <inheritdoc/>
        public Region Region => Region.Africa;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.WesternAfrica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.AR,
            Alpha2Code.BR,
            Alpha2Code.CL,
            Alpha2Code.PY,
            Alpha2Code.PE,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies =>
        [
            new ShpCurrency(),
            new GbpCurrency(),
        ];

        /// <inheritdoc/>
        public string[] CallingCodes =>
        [
            "290",
            "247",
        ];
    }
}
