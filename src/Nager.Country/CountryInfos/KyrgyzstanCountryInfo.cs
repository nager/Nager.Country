using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Kyrgyzstan
    /// </summary>
    public sealed class KyrgyzstanCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Kyrgyzstan";

        /// <inheritdoc/>
        public string OfficialName => "Kyrgyz Republic";

        /// <inheritdoc/>
        public string NativeName => "Кыргызстан";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.KG;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.KGZ;

        /// <inheritdoc/>
        public int NumericCode => 417;

        /// <inheritdoc/>
        public string[] TLD => [".kg"];

        /// <inheritdoc/>
        public Region Region => Region.Asia;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.CentralAsia;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.CN,
            Alpha2Code.KZ,
            Alpha2Code.TJ,
            Alpha2Code.UZ,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [KgsCurrency.Instance];

        /// <inheritdoc/>
        public string[] CallingCodes => ["996"];
    }
}
