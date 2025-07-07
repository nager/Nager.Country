using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Niue
    /// </summary>
    public sealed class NiueCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Niue";

        /// <inheritdoc/>
        public string OfficialName => "Niue";

        /// <inheritdoc/>
        public string NativeName => "Niuē";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.NU;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.NIU;

        /// <inheritdoc/>
        public int NumericCode => 570;

        /// <inheritdoc/>
        public string[] TLD => new [] { ".nu" };

        /// <inheritdoc/>
        public Region Region => Region.Oceania;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.Polynesia;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => [];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new NzdCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["683"];
    }
}
