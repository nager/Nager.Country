using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Greenland
    /// </summary>
    public sealed class GreenlandCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Greenland";

        /// <inheritdoc/>
        public string OfficialName => "Greenland";

        /// <inheritdoc/>
        public string NativeName => "Kalaallit Nunaat";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.GL;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.GRL;

        /// <inheritdoc/>
        public int NumericCode => 304;

        /// <inheritdoc/>
        public string[] TLD => [".gl"];

        /// <inheritdoc/>
        public Region Region => Region.Americas;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.NorthAmerica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => [];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new DkkCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["299"];
    }
}
