using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Cayman Islands
    /// </summary>
    public class CaymanIslandsCountryInfo : ICountryInfo
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
        public string[] TLD => new [] { ".ky" };

        /// <inheritdoc/>
        public Region Region => Region.Americas;
        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.Caribbean;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        /// <inheritdoc/>
        public ICurrency[] Currencies => new [] { new KydCurrency() };
        /// <inheritdoc/>
        public string[] CallingCodes => new [] { "1345" };
    }
}
