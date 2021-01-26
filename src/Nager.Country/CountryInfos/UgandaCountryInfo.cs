using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Uganda
    /// </summary>
    public class UgandaCountryInfo : ICountryInfo
    {
        public string CommonName => "Uganda";
        public string OfficialName => "Republic of Uganda";
        public Alpha2Code Alpha2Code => Alpha2Code.UG;
        public Alpha3Code Alpha3Code => Alpha3Code.UGA;
        public int NumericCode => 800;
        public string[] TLD => new [] { ".ug" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.EasternAfrica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.CD,
            Alpha2Code.KE,
            Alpha2Code.RW,
            Alpha2Code.SS,
            Alpha2Code.TZ,
        };

        public ICurrency[] Currencies => new [] { new UgxCurrency() };
        public string[] CallingCodes => new [] { "256" };
    }
}
