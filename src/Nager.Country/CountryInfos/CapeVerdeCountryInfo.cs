using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Cape Verde
    /// </summary>
    public class CapeVerdeCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Cape Verde";
        /// <inheritdoc/>
        public string OfficialName => "Republic of Cabo Verde";
        /// <inheritdoc/>
        public string NativeName => "Cabo Verde";
        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.CV;
        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.CPV;
        /// <inheritdoc/>
        public int NumericCode => 132;
        /// <inheritdoc/>
        public string[] TLD => new [] { ".cv" };

        /// <inheritdoc/>
        public Region Region => Region.Africa;
        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.WesternAfrica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        /// <inheritdoc/>
        public ICurrency[] Currencies => new [] { new CveCurrency() };
        /// <inheritdoc/>
        public string[] CallingCodes => new [] { "238" };
    }
}
