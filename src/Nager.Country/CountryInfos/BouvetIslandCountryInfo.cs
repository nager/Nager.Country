using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Bouvet Island
    /// </summary>
    public class BouvetIslandCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Bouvet Island";
        /// <inheritdoc/>
        public string OfficialName => "Bouvet Island";
        /// <inheritdoc/>
        public string NativeName => "Bouvetøya";
        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.BV;
        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.BVT;
        /// <inheritdoc/>
        public int NumericCode => 074;
        /// <inheritdoc/>
        public string[] TLD => new [] { ".bv" };

        /// <inheritdoc/>
        public Region Region => Region.Antarctic;
        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.None;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        /// <inheritdoc/>
        public ICurrency[] Currencies => new [] { new NokCurrency() };
        /// <inheritdoc/>
        public string[] CallingCodes => new string[0];
    }
}
