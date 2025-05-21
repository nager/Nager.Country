using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Antigua and Barbuda
    /// </summary>
    public class AntiguaAndBarbudaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Antigua and Barbuda";
        /// <inheritdoc/>
        public string OfficialName => "Antigua and Barbuda";
        /// <inheritdoc/>
        public string NativeName => "Antigua and Barbuda";
        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.AG;
        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.ATG;
        /// <inheritdoc/>
        public int NumericCode => 028;
        /// <inheritdoc/>
        public string[] TLD => new [] { ".ag" };

        /// <inheritdoc/>
        public Region Region => Region.Americas;
        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.Caribbean;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        /// <inheritdoc/>
        public ICurrency[] Currencies => new [] { new XcdCurrency() };
        /// <inheritdoc/>
        public string[] CallingCodes => new [] { "1268" };
    }
}
