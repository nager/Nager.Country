using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// British Virgin Islands
    /// </summary>
    public class BritishVirginIslandsCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "British Virgin Islands";
        ///<inheritdoc/>
        public string OfficialName => "Virgin Islands";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.VG;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.VGB;
        ///<inheritdoc/>
        public int NumericCode => 092;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".vg" };

        ///<inheritdoc/>
        public Region Region => Region.Americas;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.Caribbean;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new UsdCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "1284" };
    }
}
