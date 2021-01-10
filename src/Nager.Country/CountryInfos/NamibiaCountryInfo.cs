using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Namibia
    /// </summary>
    public class NamibiaCountryInfo : ICountryInfo
    {
        public string CommonName => "Namibia";
        public string OfficialName => "Republic of Namibia";
        public Alpha2Code Alpha2Code => Alpha2Code.NA;
        public Alpha3Code Alpha3Code => Alpha3Code.NAM;
        public int NumericCode => 516;
        public string[] TLD => new [] { ".na" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.SouthernAfrica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.AO,
            Alpha2Code.BW,
            Alpha2Code.ZA,
            Alpha2Code.ZM,
        };

        public ICurrency[] Currencies => new ICurrency[] { new NadCurrency(), new ZarCurrency() };
        public string[] CallingCodes => new [] { "264" };
    }
}
