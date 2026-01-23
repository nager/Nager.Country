using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Latvia
    /// </summary>
    public sealed class LatviaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Latvia";

        /// <inheritdoc/>
        public string OfficialName => "Republic of Latvia";

        /// <inheritdoc/>
        public string NativeName => "Latvija";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.LV;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.LVA;

        /// <inheritdoc/>
        public int NumericCode => 428;

        /// <inheritdoc/>
        public string[] TLD => [".lv"];

        /// <inheritdoc/>
        public Region Region => Region.Europe;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.NorthernEurope;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.BY,
            Alpha2Code.EE,
            Alpha2Code.LT,
            Alpha2Code.RU,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [EurCurrency.Instance];

        /// <inheritdoc/>
        public string[] CallingCodes => ["371"];
    }
}
