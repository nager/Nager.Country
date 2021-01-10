using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// El Salvador
    /// </summary>
    public class ElSalvadorCountryInfo : ICountryInfo
    {
        public string CommonName => "El Salvador";
        public string OfficialName => "Republic of El Salvador";
        public Alpha2Code Alpha2Code => Alpha2Code.SV;
        public Alpha3Code Alpha3Code => Alpha3Code.SLV;
        public int NumericCode => 222;
        public string[] TLD => new [] { ".sv" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.CentralAmerica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.GT,
            Alpha2Code.HN,
        };

        public ICurrency[] Currencies => new ICurrency[] { new SvcCurrency(), new UsdCurrency() };
        public string[] CallingCodes => new [] { "503" };
    }
}
