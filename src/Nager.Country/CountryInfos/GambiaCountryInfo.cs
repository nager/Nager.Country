using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Gambia
    /// </summary>
    public class GambiaCountryInfo : ICountryInfo
    {
        public string CommonName => "Gambia";
        public string OfficialName => "Republic of the Gambia";
        public Alpha2Code Alpha2Code => Alpha2Code.GM;
        public Alpha3Code Alpha3Code => Alpha3Code.GMB;
        public int NumericCode => 270;
        public string[] TLD => new [] { ".gm" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.WesternAfrica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.SN,
        };

        public ICurrency[] Currencies => new [] { new GmdCurrency() };
        public string[] CallingCodes => new [] { "220" };
    }
}
