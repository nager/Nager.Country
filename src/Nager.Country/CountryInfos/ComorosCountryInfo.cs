using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Comoros
    /// </summary>
    public sealed class ComorosCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Comoros";

        /// <inheritdoc/>
        public string OfficialName => "Union of the Comoros";

        /// <inheritdoc/>
        public string NativeName => "Komori";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.KM;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.COM;

        /// <inheritdoc/>
        public int NumericCode => 174;

        /// <inheritdoc/>
        public string[] TLD => [".km"];

        /// <inheritdoc/>
        public Region Region => Region.Africa;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.EasternAfrica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => [];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [KmfCurrency.Instance];

        /// <inheritdoc/>
        public string[] CallingCodes => ["269"];
    }
}
