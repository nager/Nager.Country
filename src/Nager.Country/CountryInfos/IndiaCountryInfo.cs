using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// India
    /// </summary>
    public class IndiaCountryInfo : ICountryInfo
    {
        public string CommonName => "India";
        public string OfficialName => "Republic of India";
        public Alpha2Code Alpha2Code => Alpha2Code.IN;
        public Alpha3Code Alpha3Code => Alpha3Code.IND;
        public int NumericCode => 356;
        public string[] TLD => new [] { ".in" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.SouthernAsia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.AF,
            Alpha2Code.BD,
            Alpha2Code.BT,
            Alpha2Code.MM,
            Alpha2Code.CN,
            Alpha2Code.NP,
            Alpha2Code.PK,
            Alpha2Code.LK,
        };

        public ICurrency[] Currencies => new [] { new InrCurrency() };
        public string[] CallingCodes => new [] { "91" };
    }
}
