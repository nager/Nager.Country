using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Finland
    /// </summary>
    public sealed class FinlandCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Finland";

        /// <inheritdoc/>
        public string OfficialName => "Republic of Finland";

        /// <inheritdoc/>
        public string NativeName => "Suomi";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.FI;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.FIN;

        /// <inheritdoc/>
        public int NumericCode => 246;

        /// <inheritdoc/>
        public string[] TLD => [".fi"];

        /// <inheritdoc/>
        public Region Region => Region.Europe;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.NorthernEurope;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.NO,
            Alpha2Code.SE,
            Alpha2Code.RU,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new EurCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["358"];
    }
}
