using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// New Zealand
    /// </summary>
    public sealed class NewZealandCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "New Zealand";

        /// <inheritdoc/>
        public string OfficialName => "New Zealand";

        /// <inheritdoc/>
        public string NativeName => "New Zealand";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.NZ;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.NZL;

        /// <inheritdoc/>
        public int NumericCode => 554;

        /// <inheritdoc/>
        public string[] TLD => new [] { ".nz" };

        /// <inheritdoc/>
        public Region Region => Region.Oceania;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.AustraliaAndNewZealand;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        /// <inheritdoc/>
        public ICurrency[] Currencies => new [] { new NzdCurrency() };

        /// <inheritdoc/>
        public string[] CallingCodes => new [] { "64" };
    }
}
