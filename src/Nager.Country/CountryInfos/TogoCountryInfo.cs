using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Togo
    /// </summary>
    public sealed class TogoCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Togo";

        /// <inheritdoc/>
        public string OfficialName => "Togolese Republic";

        /// <inheritdoc/>
        public string NativeName => "Togo";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.TG;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.TGO;

        /// <inheritdoc/>
        public int NumericCode => 768;

        /// <inheritdoc/>
        public string[] TLD => new [] { ".tg" };

        /// <inheritdoc/>
        public Region Region => Region.Africa;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.WesternAfrica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.BJ,
            Alpha2Code.BF,
            Alpha2Code.GH,
        };

        /// <inheritdoc/>
        public ICurrency[] Currencies => new [] { new XofCurrency() };

        /// <inheritdoc/>
        public string[] CallingCodes => new [] { "228" };
    }
}
