using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Egypt
    /// </summary>
    public class EgyptCountryInfo : ICountryInfo
    {
        public string CommonName => "Egypt";
        public string OfficialName => "Arab Republic of Egypt";
        public Alpha2Code Alpha2Code => Alpha2Code.EG;
        public Alpha3Code Alpha3Code => Alpha3Code.EGY;
        public int NumericCode => 818;
        public string[] TLD => new [] { ".eg", ".مصر" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.NorthernAfrica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.IL,
            Alpha2Code.LY,
            Alpha2Code.SD,
        };

        public ICurrency[] Currencies => new [] { new EgpCurrency() };
        public string[] CallingCodes => new [] { "20" };
    }
}
