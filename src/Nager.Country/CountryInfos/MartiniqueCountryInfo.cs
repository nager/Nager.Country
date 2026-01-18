using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Martinique
    /// </summary>
    public sealed class MartiniqueCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Martinique";

        /// <inheritdoc/>
        public string OfficialName => "Martinique";

        /// <inheritdoc/>
        public string NativeName => "Martinique";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.MQ;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.MTQ;

        /// <inheritdoc/>
        public int NumericCode => 474;

        /// <inheritdoc/>
        public string[] TLD => [".mq"];

        /// <inheritdoc/>
        public Region Region => Region.Americas;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.Caribbean;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => [];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [EurCurrency.Instance];

        /// <inheritdoc/>
        public string[] CallingCodes => ["596"];
    }
}
