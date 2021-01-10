using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Afghanistan
    /// </summary>
    public class AfghanistanCountryInfo : ICountryInfo
    {
        public string CommonName => "Afghanistan";
        public string OfficialName => "Islamic Republic of Afghanistan";
        public Alpha2Code Alpha2Code => Alpha2Code.AF;
        public Alpha3Code Alpha3Code => Alpha3Code.AFG;
        public int NumericCode => 004;
        public string[] TLD => new [] { ".af" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.SouthernAsia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.IR,
            Alpha2Code.PK,
            Alpha2Code.TM,
            Alpha2Code.UZ,
            Alpha2Code.TJ,
            Alpha2Code.CN,
        };

        public ICurrency[] Currencies => new [] { new AfnCurrency() };

        public string[] CallingCodes => new [] { "93" };
    }
}
