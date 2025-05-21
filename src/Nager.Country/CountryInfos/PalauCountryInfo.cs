using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Palau
    /// </summary>
    public class PalauCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Palau";
        /// <inheritdoc/>
        public string OfficialName => "Republic of Palau";
        /// <inheritdoc/>
        public string NativeName => "Palau";
        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.PW;
        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.PLW;
        /// <inheritdoc/>
        public int NumericCode => 585;
        /// <inheritdoc/>
        public string[] TLD => new [] { ".pw" };

        /// <inheritdoc/>
        public Region Region => Region.Oceania;
        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.Micronesia;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        /// <inheritdoc/>
        public ICurrency[] Currencies => new [] { new UsdCurrency() };
        /// <inheritdoc/>
        public string[] CallingCodes => new [] { "680" };
    }
}
