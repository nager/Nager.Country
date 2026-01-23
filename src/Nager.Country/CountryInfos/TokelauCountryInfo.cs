using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Tokelau
    /// </summary>
    public sealed class TokelauCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Tokelau";

        /// <inheritdoc/>
        public string OfficialName => "Tokelau";

        /// <inheritdoc/>
        public string NativeName => "Tokelau";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.TK;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.TKL;

        /// <inheritdoc/>
        public int NumericCode => 772;

        /// <inheritdoc/>
        public string[] TLD => [".tk"];

        /// <inheritdoc/>
        public Region Region => Region.Oceania;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.Polynesia;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => [];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [NzdCurrency.Instance];

        /// <inheritdoc/>
        public string[] CallingCodes => ["690"];
    }
}
