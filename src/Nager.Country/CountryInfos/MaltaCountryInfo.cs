using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Malta
    /// </summary>
    public sealed class MaltaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Malta";

        /// <inheritdoc/>
        public string OfficialName => "Republic of Malta";

        /// <inheritdoc/>
        public string NativeName => "Malta";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.MT;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.MLT;

        /// <inheritdoc/>
        public int NumericCode => 470;

        /// <inheritdoc/>
        public string[] TLD => [".mt"];

        /// <inheritdoc/>
        public Region Region => Region.Europe;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthernEurope;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => [];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [EurCurrency.Instance];

        /// <inheritdoc/>
        public string[] CallingCodes => ["356"];
    }
}
