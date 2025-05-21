using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Sri Lanka
    /// </summary>
    public class SriLankaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Sri Lanka";
        /// <inheritdoc/>
        public string OfficialName => "Democratic Socialist Republic of Sri Lanka";
        /// <inheritdoc/>
        public string NativeName => "śrī laṃkāva";
        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.LK;
        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.LKA;
        /// <inheritdoc/>
        public int NumericCode => 144;
        /// <inheritdoc/>
        public string[] TLD => new [] { ".lk", ".இலங்கை", ".ලංකා" };

        /// <inheritdoc/>
        public Region Region => Region.Asia;
        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthernAsia;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.IN,
        };

        /// <inheritdoc/>
        public ICurrency[] Currencies => new [] { new LkrCurrency() };
        /// <inheritdoc/>
        public string[] CallingCodes => new [] { "94" };
    }
}
