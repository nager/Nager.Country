using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Falkland Islands
    /// </summary>
    public class FalklandIslandsCountryInfo : ICountryInfo
    {
        public string CommonName => "Falkland Islands";
        public string OfficialName => "Falkland Islands";
        public Alpha2Code Alpha2Code => Alpha2Code.FK;
        public Alpha3Code Alpha3Code => Alpha3Code.FLK;
        public int NumericCode => 238;
        public string[] TLD => new [] { ".fk" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.SouthAmerica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new FkpCurrency() };
        public string[] CallingCodes => new [] { "500" };
    }
}
