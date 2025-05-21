using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Suriname
    /// </summary>
    public class SurinameCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Suriname";
        /// <inheritdoc/>
        public string OfficialName => "Republic of Suriname";
        /// <inheritdoc/>
        public string NativeName => "Suriname";
        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.SR;
        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.SUR;
        /// <inheritdoc/>
        public int NumericCode => 740;
        /// <inheritdoc/>
        public string[] TLD => new [] { ".sr" };

        /// <inheritdoc/>
        public Region Region => Region.Americas;
        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthAmerica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.BR,
            Alpha2Code.GF,
            Alpha2Code.GY,
        };

        /// <inheritdoc/>
        public ICurrency[] Currencies => new [] { new SrdCurrency() };
        /// <inheritdoc/>
        public string[] CallingCodes => new [] { "597" };
    }
}
