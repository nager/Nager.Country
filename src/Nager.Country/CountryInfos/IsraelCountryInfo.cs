using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Israel
    /// </summary>
    public class IsraelCountryInfo : ICountryInfo
    {
        public string CommonName => "Israel";
        public string OfficialName => "State of Israel";
        public Alpha2Code Alpha2Code => Alpha2Code.IL;
        public Alpha3Code Alpha3Code => Alpha3Code.ISR;
        public int NumericCode => 376;
        public string[] TLD => new [] { ".il" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.WesternAsia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.EG,
            Alpha2Code.JO,
            Alpha2Code.LB,
            Alpha2Code.SY,
        };

        public ICurrency[] Currencies => new [] { new IlsCurrency() };
        public string[] CallingCodes => new [] { "972" };
    }
}
