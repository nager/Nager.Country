using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// British Indian Ocean Territory
    /// </summary>
    public class BritishIndianOceanTerritoryCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "British Indian Ocean Territory";
        ///<inheritdoc/>
        public string OfficialName => "British Indian Ocean Territory";
        ///<inheritdoc/>
        public string NativeName => "British Indian Ocean Territory";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.IO;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.IOT;
        ///<inheritdoc/>
        public int NumericCode => 086;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".io" };

        ///<inheritdoc/>
        public Region Region => Region.Africa;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.EasternAfrica;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new UsdCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "246" };
    }
}
