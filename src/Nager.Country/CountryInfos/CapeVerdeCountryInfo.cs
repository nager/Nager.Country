using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Cape Verde
    /// </summary>
    public sealed class CapeVerdeCountryInfo : ICountryInfo
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
        public string[] TLD => [".cv"];

        /// <inheritdoc/>
        public Region Region => Region.Africa;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.WesternAfrica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => [];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [CveCurrency.Instance];

        /// <inheritdoc/>
        public string[] CallingCodes => ["238"];
    }
}
