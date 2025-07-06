using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// South Korea
    /// </summary>
    public sealed class SouthKoreaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "South Korea";

        /// <inheritdoc/>
        public string OfficialName => "Republic of Korea";

        /// <inheritdoc/>
        public string NativeName => "대한민국";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.KR;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.KOR;

        /// <inheritdoc/>
        public int NumericCode => 410;

        /// <inheritdoc/>
        public string[] TLD => new [] { ".kr", ".한국" };

        /// <inheritdoc/>
        public Region Region => Region.Asia;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.EasternAsia;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.KP,
        };

        /// <inheritdoc/>
        public ICurrency[] Currencies => new [] { new KrwCurrency() };

        /// <inheritdoc/>
        public string[] CallingCodes => new [] { "82" };
    }
}
