using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Maldives
    /// </summary>
    public class MaldivesCountryInfo : ICountryInfo
    {
        public string CommonName => "Maldives";
        public string OfficialName => "Republic of the Maldives";
        public Alpha2Code Alpha2Code => Alpha2Code.MV;
        public Alpha3Code Alpha3Code => Alpha3Code.MDV;
        public int NumericCode => 462;
        public string[] TLD => new [] { ".mv" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.SouthernAsia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new MvrCurrency() };
        public string[] CallingCodes => new [] { "960" };
    }
}
