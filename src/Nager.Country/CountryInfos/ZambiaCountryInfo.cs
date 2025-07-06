using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Zambia
    /// </summary>
    public sealed class ZambiaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Zambia";

        /// <inheritdoc/>
        public string OfficialName => "Republic of Zambia";

        /// <inheritdoc/>
        public string NativeName => "Zambia";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.ZM;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.ZMB;

        /// <inheritdoc/>
        public int NumericCode => 894;

        /// <inheritdoc/>
        public string[] TLD => new [] { ".zm" };

        /// <inheritdoc/>
        public Region Region => Region.Africa;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.EasternAfrica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.AO,
            Alpha2Code.BW,
            Alpha2Code.CD,
            Alpha2Code.MW,
            Alpha2Code.MZ,
            Alpha2Code.NA,
            Alpha2Code.TZ,
            Alpha2Code.ZW,
        };

        /// <inheritdoc/>
        public ICurrency[] Currencies => new [] { new ZmwCurrency() };

        /// <inheritdoc/>
        public string[] CallingCodes => new [] { "260" };
    }
}
