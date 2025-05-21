using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Wallis and Futuna
    /// </summary>
    public class WallisAndFutunaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Wallis and Futuna";
        /// <inheritdoc/>
        public string OfficialName => "Territory of the Wallis and Futuna Islands";
        /// <inheritdoc/>
        public string NativeName => "Wallis et Futuna";
        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.WF;
        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.WLF;
        /// <inheritdoc/>
        public int NumericCode => 876;
        /// <inheritdoc/>
        public string[] TLD => new [] { ".wf" };

        /// <inheritdoc/>
        public Region Region => Region.Oceania;
        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.Polynesia;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        /// <inheritdoc/>
        public ICurrency[] Currencies => new [] { new XpfCurrency() };
        /// <inheritdoc/>
        public string[] CallingCodes => new [] { "681" };
    }
}
