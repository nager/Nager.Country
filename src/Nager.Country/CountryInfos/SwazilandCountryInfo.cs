using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Swaziland
    /// </summary>
    public sealed class SwazilandCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Eswatini";

        /// <inheritdoc/>
        public string OfficialName => "Kingdom of Swaziland";

        /// <inheritdoc/>
        public string NativeName => "Swaziland";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.SZ;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.SWZ;

        /// <inheritdoc/>
        public int NumericCode => 748;

        /// <inheritdoc/>
        public string[] TLD => new [] { ".sz" };

        /// <inheritdoc/>
        public Region Region => Region.Africa;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthernAfrica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.MZ,
            Alpha2Code.ZA,
        };

        /// <inheritdoc/>
        public ICurrency[] Currencies => new [] { new SzlCurrency() };

        /// <inheritdoc/>
        public string[] CallingCodes => new [] { "268" };
    }
}
