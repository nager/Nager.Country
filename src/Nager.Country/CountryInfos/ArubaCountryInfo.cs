using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Aruba
    /// </summary>
    public sealed class ArubaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Aruba";

        /// <inheritdoc/>
        public string OfficialName => "Aruba";

        /// <inheritdoc/>
        public string NativeName => "Aruba";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.AW;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.ABW;

        /// <inheritdoc/>
        public int NumericCode => 533;

        /// <inheritdoc/>
        public string[] TLD => [".aw"];

        /// <inheritdoc/>
        public Region Region => Region.Americas;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.Caribbean;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => [];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [AwgCurrency.Instance];

        /// <inheritdoc/>
        public string[] CallingCodes => ["297"];
    }
}
