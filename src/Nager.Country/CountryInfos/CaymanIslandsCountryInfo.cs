using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Cayman Islands
    /// </summary>
    public sealed class CaymanIslandsCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Cayman Islands";

        /// <inheritdoc/>
        public string OfficialName => "Cayman Islands";

        /// <inheritdoc/>
        public string NativeName => "Cayman Islands";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.KY;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.CYM;

        /// <inheritdoc/>
        public int NumericCode => 136;

        /// <inheritdoc/>
        public string[] TLD => [".ky"];

        /// <inheritdoc/>
        public Region Region => Region.Americas;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.Caribbean;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => [];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new KydCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["1345"];
    }
}
