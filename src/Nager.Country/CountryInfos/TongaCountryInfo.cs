using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Tonga
    /// </summary>
    public sealed class TongaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Tonga";

        /// <inheritdoc/>
        public string OfficialName => "Kingdom of Tonga";

        /// <inheritdoc/>
        public string NativeName => "Tonga";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.TO;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.TON;

        /// <inheritdoc/>
        public int NumericCode => 776;

        /// <inheritdoc/>
        public string[] TLD => [".to"];

        /// <inheritdoc/>
        public Region Region => Region.Oceania;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.Polynesia;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => [];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new TopCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["676"];
    }
}
