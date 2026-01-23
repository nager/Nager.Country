using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Guadeloupe
    /// </summary>
    public sealed class GuadeloupeCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Guadeloupe";

        /// <inheritdoc/>
        public string OfficialName => "Guadeloupe";

        /// <inheritdoc/>
        public string NativeName => "Guadeloupe";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.GP;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.GLP;

        /// <inheritdoc/>
        public int NumericCode => 312;

        /// <inheritdoc/>
        public string[] TLD => [".gp"];

        /// <inheritdoc/>
        public Region Region => Region.Americas;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.Caribbean;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => [];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [EurCurrency.Instance];

        /// <inheritdoc/>
        public string[] CallingCodes => ["590"];
    }
}
