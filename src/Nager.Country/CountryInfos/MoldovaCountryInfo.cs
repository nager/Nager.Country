using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Moldova
    /// </summary>
    public class MoldovaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Moldova";
        /// <inheritdoc/>
        public string OfficialName => "Republic of Moldova";
        /// <inheritdoc/>
        public string NativeName => "Moldova";
        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.MD;
        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.MDA;
        /// <inheritdoc/>
        public int NumericCode => 498;
        /// <inheritdoc/>
        public string[] TLD => new [] { ".md" };

        /// <inheritdoc/>
        public Region Region => Region.Europe;
        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.EasternEurope;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.RO,
            Alpha2Code.UA,
        };

        /// <inheritdoc/>
        public ICurrency[] Currencies => new [] { new MdlCurrency() };
        /// <inheritdoc/>
        public string[] CallingCodes => new [] { "373" };
    }
}
