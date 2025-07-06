using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Nepal
    /// </summary>
    public sealed class NepalCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Nepal";

        /// <inheritdoc/>
        public string OfficialName => "Federal Democratic Republic of Nepal";

        /// <inheritdoc/>
        public string NativeName => "नेपाल";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.NP;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.NPL;

        /// <inheritdoc/>
        public int NumericCode => 524;

        /// <inheritdoc/>
        public string[] TLD => new [] { ".np" };

        /// <inheritdoc/>
        public Region Region => Region.Asia;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthernAsia;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.CN,
            Alpha2Code.IN,
        };

        /// <inheritdoc/>
        public ICurrency[] Currencies => new [] { new NprCurrency() };

        /// <inheritdoc/>
        public string[] CallingCodes => new [] { "977" };
    }
}
