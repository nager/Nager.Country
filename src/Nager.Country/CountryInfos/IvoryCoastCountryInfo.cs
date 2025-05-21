using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Ivory Coast
    /// </summary>
    public class IvoryCoastCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Ivory Coast";
        /// <inheritdoc/>
        public string OfficialName => "Republic of Côte d'Ivoire";
        /// <inheritdoc/>
        public string NativeName => "Côte d'Ivoire";
        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.CI;
        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.CIV;
        /// <inheritdoc/>
        public int NumericCode => 384;
        /// <inheritdoc/>
        public string[] TLD => new [] { ".ci" };

        /// <inheritdoc/>
        public Region Region => Region.Africa;
        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.WesternAfrica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.BF,
            Alpha2Code.GH,
            Alpha2Code.GN,
            Alpha2Code.LR,
            Alpha2Code.ML,
        };

        /// <inheritdoc/>
        public ICurrency[] Currencies => new [] { new XofCurrency() };
        /// <inheritdoc/>
        public string[] CallingCodes => new [] { "225" };
    }
}
