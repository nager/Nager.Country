using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Uzbekistan
    /// </summary>
    public class UzbekistanCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Uzbekistan";
        /// <inheritdoc/>
        public string OfficialName => "Republic of Uzbekistan";
        /// <inheritdoc/>
        public string NativeName => "O‘zbekiston";
        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.UZ;
        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.UZB;
        /// <inheritdoc/>
        public int NumericCode => 860;
        /// <inheritdoc/>
        public string[] TLD => new [] { ".uz" };

        /// <inheritdoc/>
        public Region Region => Region.Asia;
        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.CentralAsia;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.AF,
            Alpha2Code.KZ,
            Alpha2Code.KG,
            Alpha2Code.TJ,
            Alpha2Code.TM,
        };

        /// <inheritdoc/>
        public ICurrency[] Currencies => new [] { new UzsCurrency() };
        /// <inheritdoc/>
        public string[] CallingCodes => new [] { "998" };
    }
}
