using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Malaysia
    /// </summary>
    public class MalaysiaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Malaysia";
        /// <inheritdoc/>
        public string OfficialName => "Malaysia";
        /// <inheritdoc/>
        public string NativeName => "Malaysia";
        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.MY;
        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.MYS;
        /// <inheritdoc/>
        public int NumericCode => 458;
        /// <inheritdoc/>
        public string[] TLD => new [] { ".my" };

        /// <inheritdoc/>
        public Region Region => Region.Asia;
        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthEasternAsia;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.BN,
            Alpha2Code.ID,
            Alpha2Code.TH,
        };

        /// <inheritdoc/>
        public ICurrency[] Currencies => new [] { new MyrCurrency() };
        /// <inheritdoc/>
        public string[] CallingCodes => new [] { "60" };
    }
}
