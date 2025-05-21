using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// United States Minor Outlying Islands
    /// </summary>
    public class UnitedStatesMinorOutlyingIslandsCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "United States Minor Outlying Islands";
        /// <inheritdoc/>
        public string OfficialName => "United States Minor Outlying Islands";
        /// <inheritdoc/>
        public string NativeName => "United States Minor Outlying Islands";
        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.UM;
        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.UMI;
        /// <inheritdoc/>
        public int NumericCode => 581;
        /// <inheritdoc/>
        public string[] TLD => new [] { ".us" };

        /// <inheritdoc/>
        public Region Region => Region.Americas;
        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.NorthAmerica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        /// <inheritdoc/>
        public ICurrency[] Currencies => new [] { new UsdCurrency() };
        /// <inheritdoc/>
        public string[] CallingCodes => new string[0];
    }
}
