using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Cyprus
    /// </summary>
    public class CyprusCountryInfo : ICountryInfo
    {
        public string CommonName => "Cyprus";
        public string OfficialName => "Republic of Cyprus";
        public Alpha2Code Alpha2Code => Alpha2Code.CY;
        public Alpha3Code Alpha3Code => Alpha3Code.CYP;
        public int NumericCode => 196;
        public string[] TLD => new [] { ".cy" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.EasternEurope;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.GB,
        };

        public ICurrency[] Currencies => new [] { new EurCurrency() };
        public string[] CallingCodes => new [] { "357" };
    }
}
