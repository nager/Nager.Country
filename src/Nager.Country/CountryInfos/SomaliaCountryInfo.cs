using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Somalia
    /// </summary>
    public class SomaliaCountryInfo : ICountryInfo
    {
        public string CommonName => "Somalia";
        public string OfficialName => "Federal Republic of Somalia";
        public Alpha2Code Alpha2Code => Alpha2Code.SO;
        public Alpha3Code Alpha3Code => Alpha3Code.SOM;
        public int NumericCode => 706;
        public string[] TLD => new [] { ".so" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.EasternAfrica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.DJ,
            Alpha2Code.ET,
            Alpha2Code.KE,
        };

        public ICurrency[] Currencies => new [] { new SosCurrency() };
        public string[] CallingCodes => new [] { "252" };
    }
}
