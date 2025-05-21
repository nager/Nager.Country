using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Jamaica
    /// </summary>
    public class JamaicaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Jamaica";
        /// <inheritdoc/>
        public string OfficialName => "Jamaica";
        /// <inheritdoc/>
        public string NativeName => "Jamaica";
        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.JM;
        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.JAM;
        /// <inheritdoc/>
        public int NumericCode => 388;
        /// <inheritdoc/>
        public string[] TLD => new [] { ".jm" };

        /// <inheritdoc/>
        public Region Region => Region.Americas;
        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.Caribbean;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        /// <inheritdoc/>
        public ICurrency[] Currencies => new [] { new JmdCurrency() };
        /// <inheritdoc/>
        public string[] CallingCodes => new [] { "1876" };
    }
}
