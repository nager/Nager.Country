using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Åland Islands
    /// </summary>
    public sealed class AlandIslandsCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Åland Islands";

        /// <inheritdoc/>
        public string OfficialName => "Åland Islands";

        /// <inheritdoc/>
        public string NativeName => "Åland";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.AX;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.ALA;

        /// <inheritdoc/>
        public int NumericCode => 248;

        /// <inheritdoc/>
        public string[] TLD => [".ax"];

        /// <inheritdoc/>
        public Region Region => Region.Europe;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.NorthernEurope;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => [];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [EurCurrency.Instance];

        /// <inheritdoc/>
        public string[] CallingCodes => ["358"];
    }
}
