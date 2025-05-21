using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Liberia
    /// </summary>
    public class LiberiaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Liberia";
        /// <inheritdoc/>
        public string OfficialName => "Republic of Liberia";
        /// <inheritdoc/>
        public string NativeName => "Liberia";
        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.LR;
        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.LBR;
        /// <inheritdoc/>
        public int NumericCode => 430;
        /// <inheritdoc/>
        public string[] TLD => new [] { ".lr" };

        /// <inheritdoc/>
        public Region Region => Region.Africa;
        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.WesternAfrica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.GN,
            Alpha2Code.CI,
            Alpha2Code.SL,
        };

        /// <inheritdoc/>
        public ICurrency[] Currencies => new [] { new LrdCurrency() };
        /// <inheritdoc/>
        public string[] CallingCodes => new [] { "231" };
    }
}
