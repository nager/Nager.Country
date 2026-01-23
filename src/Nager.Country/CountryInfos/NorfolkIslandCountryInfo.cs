using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Norfolk Island
    /// </summary>
    public sealed class NorfolkIslandCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Norfolk Island";

        /// <inheritdoc/>
        public string OfficialName => "Territory of Norfolk Island";

        /// <inheritdoc/>
        public string NativeName => "Norfolk Island";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.NF;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.NFK;

        /// <inheritdoc/>
        public int NumericCode => 574;

        /// <inheritdoc/>
        public string[] TLD => [".nf"];

        /// <inheritdoc/>
        public Region Region => Region.Oceania;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.AustraliaAndNewZealand;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => [];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [AudCurrency.Instance];

        /// <inheritdoc/>
        public string[] CallingCodes => ["672"];
    }
}
