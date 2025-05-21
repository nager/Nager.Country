using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Yemen
    /// </summary>
    public class YemenCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Yemen";
        /// <inheritdoc/>
        public string OfficialName => "Republic of Yemen";
        /// <inheritdoc/>
        public string NativeName => "اليَمَن";
        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.YE;
        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.YEM;
        /// <inheritdoc/>
        public int NumericCode => 887;
        /// <inheritdoc/>
        public string[] TLD => new [] { ".ye" };

        /// <inheritdoc/>
        public Region Region => Region.Asia;
        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.WesternAsia;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.OM,
            Alpha2Code.SA,
        };

        /// <inheritdoc/>
        public ICurrency[] Currencies => new [] { new YerCurrency() };
        /// <inheritdoc/>
        public string[] CallingCodes => new [] { "967" };
    }
}
