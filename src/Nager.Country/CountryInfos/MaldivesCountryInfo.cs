using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Maldives
    /// </summary>
    public class MaldivesCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Maldives";
        ///<inheritdoc/>
        public string OfficialName => "Republic of the Maldives";
        ///<inheritdoc/>
        public string NativeName => "Maldives";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.MV;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.MDV;
        ///<inheritdoc/>
        public int NumericCode => 462;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".mv" };

        ///<inheritdoc/>
        public Region Region => Region.Asia;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthernAsia;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new MvrCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "960" };
    }
}
