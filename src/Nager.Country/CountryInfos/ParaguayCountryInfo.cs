using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Paraguay
    /// </summary>
    public sealed class ParaguayCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Paraguay";

        /// <inheritdoc/>
        public string OfficialName => "Republic of Paraguay";

        /// <inheritdoc/>
        public string NativeName => "Paraguay";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.PY;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.PRY;

        /// <inheritdoc/>
        public int NumericCode => 600;

        /// <inheritdoc/>
        public string[] TLD => new [] { ".py" };

        /// <inheritdoc/>
        public Region Region => Region.Americas;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthAmerica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.AR,
            Alpha2Code.BO,
            Alpha2Code.BR,
        };

        /// <inheritdoc/>
        public ICurrency[] Currencies => new [] { new PygCurrency() };

        /// <inheritdoc/>
        public string[] CallingCodes => new [] { "595" };
    }
}
