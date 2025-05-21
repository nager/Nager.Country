using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Micronesia
    /// </summary>
    public class MicronesiaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Micronesia";
        /// <inheritdoc/>
        public string OfficialName => "Federated States of Micronesia";
        /// <inheritdoc/>
        public string NativeName => "Micronesia";
        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.FM;
        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.FSM;
        /// <inheritdoc/>
        public int NumericCode => 583;
        /// <inheritdoc/>
        public string[] TLD => new [] { ".fm" };

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
        public string[] CallingCodes => new [] { "691" };
    }
}
