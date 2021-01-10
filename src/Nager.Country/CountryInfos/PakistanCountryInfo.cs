using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Pakistan
    /// </summary>
    public class PakistanCountryInfo : ICountryInfo
    {
        public string CommonName => "Pakistan";
        public string OfficialName => "Islamic Republic of Pakistan";
        public Alpha2Code Alpha2Code => Alpha2Code.PK;
        public Alpha3Code Alpha3Code => Alpha3Code.PAK;
        public int NumericCode => 586;
        public string[] TLD => new [] { ".pk" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.SouthernAsia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.AF,
            Alpha2Code.CN,
            Alpha2Code.IN,
            Alpha2Code.IR,
        };

        public ICurrency[] Currencies => new [] { new PkrCurrency() };
        public string[] CallingCodes => new [] { "92" };
    }
}
