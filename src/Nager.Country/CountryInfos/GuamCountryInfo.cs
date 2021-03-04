using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Guam
    /// </summary>
    public class GuamCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Guam";
        ///<inheritdoc/>
        public string OfficialName => "Guam";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.GU;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.GUM;
        ///<inheritdoc/>
        public int NumericCode => 316;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".gu" };

        ///<inheritdoc/>
        public Region Region => Region.Oceania;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.Micronesia;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new UsdCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "1671" };
    }
}
