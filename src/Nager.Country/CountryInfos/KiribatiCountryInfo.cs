using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Kiribati
    /// </summary>
    public class KiribatiCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Kiribati";
        /// <inheritdoc/>
        public string OfficialName => "Independent and Sovereign Republic of Kiribati";
        /// <inheritdoc/>
        public string NativeName => "Kiribati";
        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.KI;
        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.KIR;
        /// <inheritdoc/>
        public int NumericCode => 296;
        /// <inheritdoc/>
        public string[] TLD => new [] { ".ki" };

        /// <inheritdoc/>
        public Region Region => Region.Oceania;
        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.Micronesia;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        /// <inheritdoc/>
        public ICurrency[] Currencies => new [] { new AudCurrency() };
        /// <inheritdoc/>
        public string[] CallingCodes => new [] { "686" };
    }
}
