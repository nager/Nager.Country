using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// North Korea
    /// </summary>
    public class NorthKoreaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "North Korea";
        /// <inheritdoc/>
        public string OfficialName => "Democratic People's Republic of Korea";
        /// <inheritdoc/>
        public string NativeName => "북한";
        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.KP;
        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.PRK;
        /// <inheritdoc/>
        public int NumericCode => 408;
        /// <inheritdoc/>
        public string[] TLD => new [] { ".kp" };

        /// <inheritdoc/>
        public Region Region => Region.Asia;
        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.EasternAsia;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.CN,
            Alpha2Code.KR,
            Alpha2Code.RU,
        };

        /// <inheritdoc/>
        public ICurrency[] Currencies => new [] { new KpwCurrency() };
        /// <inheritdoc/>
        public string[] CallingCodes => new [] { "850" };
    }
}
