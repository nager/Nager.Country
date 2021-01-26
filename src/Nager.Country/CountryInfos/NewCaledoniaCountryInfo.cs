using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// New Caledonia
    /// </summary>
    public class NewCaledoniaCountryInfo : ICountryInfo
    {
        public string CommonName => "New Caledonia";
        public string OfficialName => "New Caledonia";
        public Alpha2Code Alpha2Code => Alpha2Code.NC;
        public Alpha3Code Alpha3Code => Alpha3Code.NCL;
        public int NumericCode => 540;
        public string[] TLD => new [] { ".nc" };

        public Region Region => Region.Oceania;
        public SubRegion SubRegion => SubRegion.Melanesia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new XpfCurrency() };
        public string[] CallingCodes => new [] { "687" };
    }
}
