using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Saint Vincent and the Grenadines
    /// </summary>
    public sealed class SaintVincentAndTheGrenadinesCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Saint Vincent and the Grenadines";

        /// <inheritdoc/>
        public string OfficialName => "Saint Vincent and the Grenadines";

        /// <inheritdoc/>
        public string NativeName => "Saint Vincent and the Grenadines";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.VC;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.VCT;

        /// <inheritdoc/>
        public int NumericCode => 670;

        /// <inheritdoc/>
        public string[] TLD => [".vc"];

        /// <inheritdoc/>
        public Region Region => Region.Americas;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.Caribbean;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => [];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [XcdCurrency.Instance];

        /// <inheritdoc/>
        public string[] CallingCodes => ["1784"];
    }
}
