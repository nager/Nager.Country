using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Guinea-Bissau
    /// </summary>
    public class GuineaBissauCountryInfo : ICountryInfo
    {
        public string CommonName => "Guinea-Bissau";
        public string OfficialName => "Republic of Guinea-Bissau";
        public Alpha2Code Alpha2Code => Alpha2Code.GW;
        public Alpha3Code Alpha3Code => Alpha3Code.GNB;
        public int NumericCode => 624;
        public string[] TLD => new [] { ".gw" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.WesternAfrica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.GN,
            Alpha2Code.SN,
        };

        public ICurrency[] Currencies => new [] { new XofCurrency() };
        public string[] CallingCodes => new [] { "245" };
    }
}
