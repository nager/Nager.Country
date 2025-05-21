using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// India
    /// </summary>
    public class IndiaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "India";
        /// <inheritdoc/>
        public string OfficialName => "Republic of India";
        /// <inheritdoc/>
        public string NativeName => "भारत";
        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.IN;
        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.IND;
        /// <inheritdoc/>
        public int NumericCode => 356;
        /// <inheritdoc/>
        public string[] TLD => new [] { ".in" };

        /// <inheritdoc/>
        public Region Region => Region.Asia;
        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthernAsia;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.AF,
            Alpha2Code.BD,
            Alpha2Code.BT,
            Alpha2Code.MM,
            Alpha2Code.CN,
            Alpha2Code.NP,
            Alpha2Code.PK,
            Alpha2Code.LK,
        };

        /// <inheritdoc/>
        public ICurrency[] Currencies => new [] { new InrCurrency() };
        /// <inheritdoc/>
        public string[] CallingCodes => new [] { "91" };
    }
}
