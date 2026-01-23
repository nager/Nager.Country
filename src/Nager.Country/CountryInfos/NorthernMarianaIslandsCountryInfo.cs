using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Northern Mariana Islands
    /// </summary>
    public sealed class NorthernMarianaIslandsCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Northern Mariana Islands";

        /// <inheritdoc/>
        public string OfficialName => "Commonwealth of the Northern Mariana Islands";

        /// <inheritdoc/>
        public string NativeName => "Northern Mariana Islands";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.MP;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.MNP;

        /// <inheritdoc/>
        public int NumericCode => 580;

        /// <inheritdoc/>
        public string[] TLD => [".mp"];

        /// <inheritdoc/>
        public Region Region => Region.Oceania;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.Micronesia;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => [];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [UsdCurrency.Instance];

        /// <inheritdoc/>
        public string[] CallingCodes => ["1670"];
    }
}
