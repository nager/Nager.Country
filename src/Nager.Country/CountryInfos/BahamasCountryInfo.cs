using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Bahamas
    /// </summary>
    public sealed class BahamasCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Bahamas";

        /// <inheritdoc/>
        public string OfficialName => "Commonwealth of the Bahamas";

        /// <inheritdoc/>
        public string NativeName => "Bahamas";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.BS;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.BHS;

        /// <inheritdoc/>
        public int NumericCode => 044;

        /// <inheritdoc/>
        public string[] TLD => [".bs"];

        /// <inheritdoc/>
        public Region Region => Region.Americas;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.Caribbean;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => [];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new BsdCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["1242"];
    }
}
