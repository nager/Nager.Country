using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Mali
    /// </summary>
    public class MaliCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Mali";
        /// <inheritdoc/>
        public string OfficialName => "Republic of Mali";
        /// <inheritdoc/>
        public string NativeName => "Mali";
        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.ML;
        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.MLI;
        /// <inheritdoc/>
        public int NumericCode => 466;
        /// <inheritdoc/>
        public string[] TLD => new [] { ".ml" };

        /// <inheritdoc/>
        public Region Region => Region.Africa;
        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.WesternAfrica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.DZ,
            Alpha2Code.BF,
            Alpha2Code.GN,
            Alpha2Code.CI,
            Alpha2Code.MR,
            Alpha2Code.NE,
            Alpha2Code.SN,
        };

        /// <inheritdoc/>
        public ICurrency[] Currencies => new [] { new XofCurrency() };
        /// <inheritdoc/>
        public string[] CallingCodes => new [] { "223" };
    }
}
