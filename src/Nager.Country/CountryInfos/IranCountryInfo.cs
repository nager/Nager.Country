using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Iran
    /// </summary>
    public class IranCountryInfo : ICountryInfo
    {
        public string CommonName => "Iran";
        public string OfficialName => "Islamic Republic of Iran";
        public Alpha2Code Alpha2Code => Alpha2Code.IR;
        public Alpha3Code Alpha3Code => Alpha3Code.IRN;
        public int NumericCode => 364;
        public string[] TLD => new [] { ".ir", "ایران." };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.SouthernAsia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.AF,
            Alpha2Code.AM,
            Alpha2Code.AZ,
            Alpha2Code.IQ,
            Alpha2Code.PK,
            Alpha2Code.TR,
            Alpha2Code.TM,
        };

        public ICurrency[] Currencies => new [] { new IrrCurrency() };
        public string[] CallingCodes => new [] { "98" };
    }
}
