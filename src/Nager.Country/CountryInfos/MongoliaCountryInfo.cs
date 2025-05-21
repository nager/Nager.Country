using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Mongolia
    /// </summary>
    public class MongoliaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Mongolia";
        /// <inheritdoc/>
        public string OfficialName => "Mongolia";
        /// <inheritdoc/>
        public string NativeName => "Монгол улс";
        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.MN;
        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.MNG;
        /// <inheritdoc/>
        public int NumericCode => 496;
        /// <inheritdoc/>
        public string[] TLD => new [] { ".mn" };

        /// <inheritdoc/>
        public Region Region => Region.Asia;
        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.EasternAsia;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.CN,
            Alpha2Code.RU,
        };

        /// <inheritdoc/>
        public ICurrency[] Currencies => new [] { new MntCurrency() };
        /// <inheritdoc/>
        public string[] CallingCodes => new [] { "976" };
    }
}
