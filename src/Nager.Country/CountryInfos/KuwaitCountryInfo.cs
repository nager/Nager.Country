using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Kuwait
    /// </summary>
    public sealed class KuwaitCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Kuwait";

        /// <inheritdoc/>
        public string OfficialName => "State of Kuwait";

        /// <inheritdoc/>
        public string NativeName => "الكويت";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.KW;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.KWT;

        /// <inheritdoc/>
        public int NumericCode => 414;

        /// <inheritdoc/>
        public string[] TLD => [".kw"];

        /// <inheritdoc/>
        public Region Region => Region.Asia;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.WesternAsia;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.IQ,
            Alpha2Code.SA,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [KwdCurrency.Instance];

        /// <inheritdoc/>
        public string[] CallingCodes => ["965"];
    }
}
