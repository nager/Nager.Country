using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Myanmar
    /// </summary>
    public class MyanmarCountryInfo : ICountryInfo
    {
        public string CommonName => "Myanmar";
        public string OfficialName => "Republic of the Union of Myanmar";
        public Alpha2Code Alpha2Code => Alpha2Code.MM;
        public Alpha3Code Alpha3Code => Alpha3Code.MMR;
        public int NumericCode => 104;
        public string[] TLD => new [] { ".mm" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.SouthEasternAsia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.BD,
            Alpha2Code.CN,
            Alpha2Code.IN,
            Alpha2Code.LA,
            Alpha2Code.TH,
        };

        public ICurrency[] Currencies => new [] { new MmkCurrency() };
        public string[] CallingCodes => new [] { "95" };
    }
}
