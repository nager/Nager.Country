using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// New Caledonia
    /// </summary>
    public sealed class NewCaledoniaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "New Caledonia";

        /// <inheritdoc/>
        public string OfficialName => "New Caledonia";

        /// <inheritdoc/>
        public string NativeName => "Nouvelle-Calédonie";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.NC;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.NCL;

        /// <inheritdoc/>
        public int NumericCode => 540;

        /// <inheritdoc/>
        public string[] TLD => [".nc"];

        /// <inheritdoc/>
        public Region Region => Region.Oceania;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.Melanesia;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => [];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [XpfCurrency.Instance];

        /// <inheritdoc/>
        public string[] CallingCodes => ["687"];
    }
}
