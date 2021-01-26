using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Uzbekistan
    /// </summary>
    public class UzbekistanCountryInfo : ICountryInfo
    {
        public string CommonName => "Uzbekistan";
        public string OfficialName => "Republic of Uzbekistan";
        public Alpha2Code Alpha2Code => Alpha2Code.UZ;
        public Alpha3Code Alpha3Code => Alpha3Code.UZB;
        public int NumericCode => 860;
        public string[] TLD => new [] { ".uz" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.CentralAsia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.AF,
            Alpha2Code.KZ,
            Alpha2Code.KG,
            Alpha2Code.TJ,
            Alpha2Code.TM,
        };

        public ICurrency[] Currencies => new [] { new UzsCurrency() };
        public string[] CallingCodes => new [] { "998" };
    }
}
