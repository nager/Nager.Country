using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Tajikistan
    /// </summary>
    public class TajikistanCountryInfo : ICountryInfo
    {
        public string CommonName => "Tajikistan";
        public string OfficialName => "Republic of Tajikistan";
        public Alpha2Code Alpha2Code => Alpha2Code.TJ;
        public Alpha3Code Alpha3Code => Alpha3Code.TJK;
        public int NumericCode => 762;
        public string[] TLD => new [] { ".tj" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.CentralAsia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.AF,
            Alpha2Code.CN,
            Alpha2Code.KG,
            Alpha2Code.UZ,
        };

        public ICurrency[] Currencies => new [] { new TjsCurrency() };
        public string[] CallingCodes => new [] { "992" };
    }
}
