using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Madagascar
    /// </summary>
    public class MadagascarCountryInfo : ICountryInfo
    {
        public string CommonName => "Madagascar";
        public string OfficialName => "Republic of Madagascar";
        public Alpha2Code Alpha2Code => Alpha2Code.MG;
        public Alpha3Code Alpha3Code => Alpha3Code.MDG;
        public int NumericCode => 450;
        public string[] TLD => new [] { ".mg" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.EasternAfrica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new MgaCurrency() };
        public string[] CallingCodes => new [] { "261" };
    }
}
