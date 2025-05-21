using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Montenegro
    /// </summary>
    public class MontenegroCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Montenegro";
        /// <inheritdoc/>
        public string OfficialName => "Montenegro";
        /// <inheritdoc/>
        public string NativeName => "Црна Гора";
        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.ME;
        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.MNE;
        /// <inheritdoc/>
        public int NumericCode => 499;
        /// <inheritdoc/>
        public string[] TLD => new [] { ".me" };

        /// <inheritdoc/>
        public Region Region => Region.Europe;
        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthernEurope;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.AL,
            Alpha2Code.BA,
            Alpha2Code.HR,
            Alpha2Code.RS,
        };

        /// <inheritdoc/>
        public ICurrency[] Currencies => new [] { new EurCurrency() };
        /// <inheritdoc/>
        public string[] CallingCodes => new [] { "382" };
    }
}
